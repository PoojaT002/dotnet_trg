using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class ExceptionHandlingDemo2
    {
        public static void MethodDivide()
        {
            try
            {
                int x, y, z;
                Console.WriteLine("Enter two numbers:");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine($"Result: {z}");
            }
            catch (DivideByZeroException ex1)
            {
                throw new Exception($"exception caught in Method Divide occured while divide by 0 {ex1.Message} \n Source :{ex1.Source}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the Program");
            }
           

        }

        static void Main(string[] args)
        {
            try
            {
                MethodDivide();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception caught in Main: {ex.Message}");
            }
            Console.ReadLine();
        }
         


        }
    }

