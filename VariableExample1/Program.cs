using System;
using System.Reflection.PortableExecutable;

namespace VariableExample1
{
    class Program
    {
        static void Main(string[] args)

        {
            //string and int are varialbles you can use to make simple edits to large pieces of code - I olnly have to change name and age
            string characterName = "Jeremy";
            int characterAge;
            characterAge = 25;
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            //You can also change the variable half-way throug by using below
            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            
        }
    }
}
