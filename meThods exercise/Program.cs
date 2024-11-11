

namespace meThodsexercise
{
    class Program
    {

        static void Method(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }


            static void Main(string[] args)
            {

                Console.Write("Enter your name: ");

                string name = Console.ReadLine();

            Method(name);   


            }
        }
    }
