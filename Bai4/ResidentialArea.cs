
namespace Bai4
{
    class ResidentialArea
    {
        private List<ResidentialUnit> units;
        public ResidentialArea() { 
            units = new List<ResidentialUnit>();
        }
        
        public void AddUnit(ResidentialUnit unit)
        {
            units.Add(unit);
        }

        public void Print()
        {
            foreach (var unit in units)
            {
                Console.WriteLine(unit.ToString());
            }
        }
    }
}
