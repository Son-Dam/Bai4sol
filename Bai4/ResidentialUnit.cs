

namespace Bai4
{
    class ResidentialUnit
    {
        private List<Person> People;
        public int Address { get; set; }   
        public ResidentialUnit(int address)
        {
            Address = address;
            People = new List<Person>();
        }
        public ResidentialUnit(int address, List<Person> People)
        {
            People = People;
            Address = address;
        }
        public ResidentialUnit(int address,params Person[] People)
        {
            this.People = new List<Person>(People);
            Address = address;
        }

        public int GetUnitMemberCount()
        {
            return People.Count;
        }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public override string ToString()
        {
            return
$@"Residential Unit {Address}, members:
    + {string.Join("\n\t+ ", People)}";
        }

    }

}
