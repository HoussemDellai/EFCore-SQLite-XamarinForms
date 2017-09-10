using Xamarin.Forms;

namespace EfCoreSqlite
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public App(IProductsRepository productsRepository)
        {
            InitializeComponent();

            var productsPage = new ProductsPage()
            {
                BindingContext = new ProductsViewModel(productsRepository)
            };

            MainPage = new NavigationPage(productsPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
