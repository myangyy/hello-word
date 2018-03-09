using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringProcessor proc1, proc2;
            Person person = new Person("s");
            proc1 = new StringProcessor(person.Say);
            proc2 = new StringProcessor(BackGround.Note);
            proc1("I miss you m");
            proc1.Invoke("I miss you m");
            proc2("An airplane file past.");
            Console.ReadKey();
        }

        delegate void StringProcessor(string input);
    }

    public class Person
    {
        public string name { get; set; }
        public Person(string name)
        {
            this.name = name;
        }
        public void Say(string message)
        {
            Console.WriteLine(name+" say "+message);
        }
    }

    public class BackGround
    {
        public static void Note(string note)
        {
            Console.WriteLine("({0})",note);
        }
    }
}
