using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{


    public class  NameChangedEventArgs : EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }

        public NameChangedEventArgs(string o, string n) : base()
        {
            OldName = o;
            NewName = n;
        }
    }
    // public delegate void NameChangedDelegate(string oldName, string newName);


    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
    class Animal
    {
        public event  NameChangedDelegate NameChanged;

        string _name = "none";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        // Null-conditional operator (c3 6) is thread safe for delegate
                        // this is much nicer than storing to a tmp, testing for null
                        // and then Invoke'ing 
                        // The “?.” operator is basically saying, if the object to the 
                        // left is not null, then fetch what is to the right, otherwise 
                        // return null and halt the access chain.

                        // NameChanged?.Invoke(_name, value);
                        NameChangedEventArgs tmpArgs = new NameChangedEventArgs(_name, value);
                       
                        NameChanged?.Invoke(this, tmpArgs);
                    }
                    _name = value;
                }
            }
        }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual string speak()
        {
            return "Hi I'm a ";
        }
        public override string ToString()
        {
            return "Animal " + Name;
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        { }

        public override string speak()
        {
            return base.speak() + "Cat"; 
            
        }
        public override string ToString()
        {
            return "I'm a cat and my name is " + Name;
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        { }

        public override string speak()
        {
            return base.speak() + "Dog";

        }
        public override string ToString()
        {

            return "I'm a dog and my name is " + Name;
        }
    }
}
