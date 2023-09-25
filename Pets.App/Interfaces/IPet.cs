using Pets.App.Enums;

namespace Pets.App.Interfaces
{
    public interface IPet
    {
        int ID { get; set; }
        string Name { get; set; }
        Animal Animal { get; set; }
        string Feed { get; set; }
        string Eat();
    }
}
