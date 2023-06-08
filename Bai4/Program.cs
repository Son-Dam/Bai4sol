namespace Bai4
{
    class Program
    {
        public static void Main(string[] args)
        {
            var ResidentialArea = new ResidentialArea();
            Console.WriteLine("Type number of residential unit you want to add:");
            int n =int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Residential Unit {i} Enter address number:");
                int address = int.Parse(Console.ReadLine());
                ResidentialUnit residentialUnit = new ResidentialUnit(address);
                Console.WriteLine($"Enter number of people in living in Residential Unit {i}:");
                int numPeople = int.Parse(Console.ReadLine());
                for(int  j = 0; j < numPeople; j++)
                {
                    Console.WriteLine($"Member #{j + 1}:");
                    Console.Write("\t+ Id:");
                    int Id = int.Parse(Console.ReadLine());
                    Console.Write("\t+ Name:");
                    string Name = Console.ReadLine();
                    Console.Write("\t+ Job:");
                    string Job = Console.ReadLine(); ;
                    Console.Write("\t+ Age:");
                    int Age = int.Parse(Console.ReadLine());
                    residentialUnit.AddMember(new Person(Id,Name,Job,Age));
                }
                ResidentialArea.AddUnit(residentialUnit);
                Console.WriteLine("Unit added successfully!");
            }

            ResidentialArea.Print();
        }
    }
}