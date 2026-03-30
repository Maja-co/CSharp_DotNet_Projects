namespace Cars {
    public class Car {
        public Car(string make, string model, int age) {
            Make = make;
            Model = model;
            Age = age;
        }

        public String Make { get; set; }
        public String Model { get; set; }
        public int Age { get; set; }
    }
}