using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number= new int[5]{1,2,3,5,3};
            // RandomArray randarr = new RandomArray();
            // randarr.getArray(number);
            //task3();

            // var Birthday = new BirthDay(new DateTime(1991, 12, 7));
            // Console.WriteLine(Birthday.Age);

            Console.WriteLine("Enter User Name");
            var username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            var password = Console.ReadLine();

            var Login = new Login(username, password);
            var authentication = Login.checkLogin();
            if (authentication) {
                Console.WriteLine("Sucess ");
            }
           
           Console.WriteLine("Fail");
        }


        public static void task1()
        {

            Console.WriteLine("Enter Number :");

            var inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber > 0 && inputNumber < 10)
            {
                Console.WriteLine("Valid Number!");
            }

            else
            {
                Console.WriteLine("Invalid Number");
            }

        }


        public static void task2()
        {

            Console.WriteLine("Enter Number1 :");

            var inputNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2 :");

            var inputNumber2 = Convert.ToInt32(Console.ReadLine());

            var maximum=  (inputNumber1 > inputNumber2)? inputNumber1 : inputNumber2;
            Console.WriteLine(maximum);


        }

        public static void task3()
        {

            Console.WriteLine("Enter width :");

            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height :");

            var height = Convert.ToInt32(Console.ReadLine());

            var size = (width > height) ? "landscape " : "portrait";
            Console.WriteLine(size);


        }
    }

}
