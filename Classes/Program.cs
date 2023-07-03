namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2013;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "626",
                Year = 2001
            };

            Car nissan = new Car("Nissan", "Maxima", 2022);

            var carList = new List<Car>() { myCar, mazda, nissan };
            
            Console.WriteLine(carList.Capacity);

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
            



        }
    }
}
