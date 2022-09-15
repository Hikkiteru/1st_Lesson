using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography;
using System.Transactions;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */
            //TASKS
            #region task_1
            Console.WriteLine("your weight and then your height(kilo,centmetr):");
            /* first i parse to uint and then convert to double in order to protect 
              my program from negative input
            */
            try
            {
                double mass = (double) uint.Parse(Console.ReadLine());
                double height = (double) uint.Parse(Console.ReadLine());
                double result = mass / (height/100 * height/100);
                Console.WriteLine($"your weight: {mass}\nyour height: {height}\nyour BMI: {result}" + "\n\n\n\n\n\n");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"you made something wrong.{ex}");
            }
               
            
                #endregion
            #region task_2            
            double a = 3.57;
            double b = 16.87;
            int grad = 280;
            double resultt = 3.14 * (a + b) / 360 * grad;
            Console.WriteLine($"the length of the ellipse sector curve: {resultt}\na = {a}\nb = {b}\ngrad = {grad}");
            #endregion
            #region task_3            
            double a0 = 28;
            double s = 12411;
            Console.WriteLine("quality: ");  
            // I use uint to protect program from negative input
            try 
            {
                uint quality = uint.Parse(Console.ReadLine());               
                double d = (2 * s / quality - 2 * a0) / (quality - 1);
                double nth_term = a0 + (quality - 1) * d;                
                Console.WriteLine($"d = {d}\nnth_term = {nth_term}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"you made something wrong.{ex}");
            }            
            #endregion
        }
    }
}
