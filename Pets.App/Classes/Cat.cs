using Pets.App.Enums;
using Pets.App.Interfaces;

namespace Pets.App.Classes
{
    public class Cat : IPet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Animal Animal { get; set; }
        public string Feed { get; set; }
        public string Eat() => $"Chewing on {Feed}.";

        public Cat(int id, string name, Animal animal, string feed) => 
            (ID, Name, Animal, Feed) = (id, name, animal, feed);
            
        }
    }
}
