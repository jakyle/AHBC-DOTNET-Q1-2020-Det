namespace OOP
{
    public class Puppers : Dog
    {
        public Puppers(int age, double weight, string name, bool isAlive, string breed, string furColor, bool isMansBestFriend) 
            : base(age, weight, name, isAlive, breed, furColor, isMansBestFriend)
        {
        }

        public bool IsDependentOnMilk { get; set; }

        public override string MakeNoise()
        {
            return $"{base.MakeNoise()}... and I'm a puppers!";
        }
    }

}


