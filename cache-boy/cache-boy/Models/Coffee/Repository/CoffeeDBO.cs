namespace cache_boy.Models.Coffee.Repository
{
    public class CoffeeDBO
    {
        // If your column is a value type, for example, bool, int, ddouble, AND in your DB that colum IS NULLable 
        // you HAVE to put a question next to your type.
        // for example
        //
        //public int? Change { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }

}
