using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11302021
{
    public class Animal { 
        public virtual void MakeSound()
        {
            Console.WriteLine("Make some genric sound");
        }
    }
    
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

}
