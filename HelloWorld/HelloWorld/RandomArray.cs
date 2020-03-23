using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class RandomArray
    {
        public void getArray(int[]random)
        {
            var firstArray = random;

            Array.Sort(firstArray);
            foreach(var element in firstArray)

                Console.WriteLine(element);



        }



    }
}
