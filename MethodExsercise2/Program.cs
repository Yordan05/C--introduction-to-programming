namespace MethodExsercise2
{
    internal class Program
    {
            static void Main(string[] args)
            {


                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("The bigger number is" + (GetMax(a, b)));
            }
            static int GetMax(int a, int b)
            {
                
                

                return Math.Max(a, b);






            }
        }
    }
