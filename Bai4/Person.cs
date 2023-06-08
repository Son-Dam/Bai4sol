

namespace Bai4
{
    class Person
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }

        public Person(int Id, string Name, string Job, int Age) {
            this.Id = Id;
            this.Name = Name;
            this.Job = Job;
            this.Age = Age;
        }
    }
}
