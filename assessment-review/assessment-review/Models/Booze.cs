
namespace assessment_review.Models
{
    public class Booze
    {
        public Booze(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
