namespace OOP
{
    public class Dog : Animal
    {
        public Dog(int age, double weight, string name, bool isAlive, string breed, string furColor, bool isMansBestFriend)
            : base(age, weight, name, isAlive)
        {
            Breed = breed;
            FurColor = furColor;
            IsMansBestFriend = isMansBestFriend;
        }

        public string Breed { get; set; }
        public string FurColor { get; set; }
        public bool IsMansBestFriend { get; set; } = true;
        public override bool IsAlive { get; set; } = true;


        public override string MakeNoise()
        {
            return $"Bark bark... I'm {Age.ToString()}";
        }
    }

}


