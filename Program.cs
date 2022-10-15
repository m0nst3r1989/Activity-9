using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        }
       
        public void Sum(int num1, int num2) 
        {
            int total;
            num1 = 4;
            num2 = 5;
            total = num1 + num2;           
        }

       

        public double avgOfDoubles(double n1, double n2, double n3, double n4, double n5, double v) {

            n1 = 5;
            n2 = 6;
            n3 = 7;
            n4 = 8;
            n5 = 9;
            double avg = n1 + n2 + n3 + n4 + n5 / 5.0;
            return avg;

        }

        public  int sumOfRandomInts()
        {
            int total;
            var random = new Random();
            int num1 = random.Next(5);
            int num2 = random.Next(5);
            total = num1 + num2;
            return total;
        }

        public static bool sumDivisible(int n1, int n2, int n3)
        {
            n1 = 5;
            n2 = 7;
            n3 = 9;
            if ((n1 + n2 + n3) % 3 == 0)
            {  //checking if the sum is divisble  by 3
                return true;  //if yes it returns true
            }
            return false;  //else it will return false
        }

        public static string showSmallString(String one, String two)
        {
            one = "Hello";
            two = "goodbye";

            if (one == two)
            {
                return two;
            }
            else
            {
                return one;
            }
        }
        public double getLargestNumber(double[] arrray)
        {
            double larg= arrray[0];
            for (int i = 1; i < arrray.Length; i++)
            {
                if (arrray[i] > larg)
                    larg = arrray[i];
            }
            return larg;
        }
        public int[] listOfFiftyInt() 
        {
            int[] array = new int[50];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;
            array[6] = 7;
            array[7] = 8;
            array[8] = 9;
                
            return array;
        }

        public bool logicalEquivalence(bool a, bool b) 
        {

        }

        public double intDoubleProduct(int a, double b) { }

        public double matrixAvg(int a[][]) { }



    }
}
