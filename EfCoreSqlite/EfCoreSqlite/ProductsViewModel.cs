using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace EfCoreSqlite
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        private readonly IProductsRepository _productsRepository;
        private IEnumerable<Product> _products;

        public IEnumerable<Product> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        public double ProductPrice { get; set; }

        public string ProductTitle { get; set; }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    Products = await _productsRepository.GetProductsAsync();
                });
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var product = new Product
                    {
                        Title = ProductTitle,
                        Price = ProductPrice,
                    };
                    await _productsRepository.AddProductAsync(product);
                });
            }
        }

        public ProductsViewModel(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
