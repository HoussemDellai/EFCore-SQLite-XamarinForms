namespace EfCoreSqlite
{

    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("({0}) {1}, {2}", Id, Title, Price);
        }
    }
}