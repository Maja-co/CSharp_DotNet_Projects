namespace APIKlient
{
    internal class Car
    {
        public Car(string make, string model, int age)
        {
            Make = make;
            Model = model;
            Age = age;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Age { get; set; }
    }
}