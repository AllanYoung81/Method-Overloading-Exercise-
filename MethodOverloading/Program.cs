namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;

        }

        public static decimal Add(decimal a, decimal b)

        { 
            return a + b; 
        }

        public static string Add(int a, int b, bool MoMoney)

        {
            if (MoMoney && a + b != 1) //can also say if (MoMoney==true)
            {
                return $"{a + b} dollars.";
            }
            else if (MoMoney && a + b == 1)  //can also say if (MoMoney==true)
            {
                return $"{a + b} dollar.";
            }
            else
            {
                return $"{a + b}";
            }


        }



        static void Main(string[] args)

        {
          int answer1 = Add(4, 4);
            Console.WriteLine(answer1);
          decimal answer2 = Add(4.5m, 4.6m);
            Console.WriteLine(answer2);
          string answer3 =  Add(3, 4, true);
            Console.WriteLine(answer3);
          string answer4 = Add(1, 0, true); //showing all instances
            Console.WriteLine(answer4);
          string answer5 = Add(3, 8, false); //showing all instances
            Console.WriteLine(answer5);
        }
    }
}
