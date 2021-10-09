using System;
using System.Collections.Generic;

//https://open.kattis.com/problems/fromatob

namespace ConsoleAppFromAtoB
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputAB = Console.ReadLine();
            List<string> inputList = new List<string>();
            inputList.AddRange(inputAB.Split(" "));


            // Step 1 Read the two numbers

            int inputA = int.Parse(inputList[0]);
            int inputB = int.Parse(inputList[1]);


            int operationsCount = 0;

            //Step 2 Start a loop that won't end until A = B
            while (inputA != inputB)
            {

                // Step 3 If A is lower than B simply do B minus A to get the number operations
                //only if it's the first iteration
                // speed up loop this way to stop TIME LIMIT EXCEEDED error
                if (inputA < inputB)
                {
                    operationsCount = operationsCount + (inputB - inputA);
                    inputA = inputB;
                }


                // Step 4 If A is greater than B and A is an even number then divide by 2.  Add one to the operations count.
                else if ((inputA > inputB) && (inputA % 2 == 0))
                {
                    inputA = inputA / 2;
                    operationsCount += 1;
                }
                else
                {
                    //Step 5 If A is greater than B and A is an odd number then add one.  Add one to the operations count.
                    inputA += 1;
                    operationsCount += 1;
                }




            }

            Console.WriteLine(operationsCount);





        }
    }
}
