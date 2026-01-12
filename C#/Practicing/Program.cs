using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Practicing
{
    sealed class Logger:Parent
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Show");
        }
    }

    class Child : Parent
    {
        public virtual new void Show()
        {
            Console.WriteLine("Child Show");
        }
    }

    class subChild : Child
    {
        public override void Show()
        {
            Console.WriteLine("sub child Show");   
        }
    }

    class Program
    {
        static void Main()
        {

            Child c = new subChild();
            Parent p = c;

            c.Show(); //sub child Show
            p.Show(); //Parent Show
        }
    }
}
