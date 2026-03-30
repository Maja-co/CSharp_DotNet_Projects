
namespace Cars
{
    public class Autoshop
    {
        private static List<Car> cars = new List<Car>(){new Car("BMW", "3", 9)};
        public static List<Car> Cars { get {  return cars; } }
        public static void AddCar(Car car)
        {
            cars.Add(car);
        }
        public static Car GetCar(int index)
        {
            return cars[index];
        }
        public static Car GetCarByName(string name)
        {
            return Cars.Find(c => c.Model == name);
        }
    }
}
