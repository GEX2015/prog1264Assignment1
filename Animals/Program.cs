using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pet = new Animal("Sammy");
            

            Console.WriteLine(pet);
            pet.Name = "Kirk";
            Console.WriteLine(pet);

            pet = new Cat("Freddy");
            pet.Name = "Kruger";
            Console.WriteLine(pet);
             
            pet = new Dog("Fido");
            pet.NameChanged += OnNameChange;  // multi task delegate
            pet.NameChanged += OnNameChange2;
            pet.NameChanged += OnNameChange;  // multi task delegate
            pet.NameChanged -= OnNameChange;  // multi task delegate

            // pet.NameChanged = null;

            pet.Name = "Freddy";
            pet.Name = "Sammy";
            Console.WriteLine(pet);

            Console.ReadKey();
        }

        // static void OnNameChange(string o, string n)
        // {
        //     Console.WriteLine($"Pets name changed from {o} to {n}");
        // }
        // 
        // static void OnNameChange2(string o, string n)
        // {
        //     Console.WriteLine($"Why did {o} change their name?");
        // }

        static void OnNameChange(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Pets name changed from {args.OldName} to {args.NewName}");
        }

        static void OnNameChange2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***********");
        }
    }
}
