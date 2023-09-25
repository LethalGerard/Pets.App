using Pets.App.Enums;
using Pets.App.Interfaces;

namespace Pets.App.Classes
{
    public class Dog : IPet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Animal Animal { get; set; }
        public string Feed { get; set; }
        public string Eat() => $"Munching on {Feed}.";

        public Dog(int id, string name, Animal animal, string feed) =>
            (ID, Name, Animal, Feed) = (id, name, animal, feed);
        
    }
}
