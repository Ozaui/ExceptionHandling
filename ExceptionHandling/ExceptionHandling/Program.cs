using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a : ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("b : ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                var result = n1 / n2;

                Console.WriteLine(result);
            }
            //////catch (DivideByZeroException ex)
            //////{
            //////    Console.WriteLine("B cannot be zero");
            //////    Console.WriteLine(ex.Message);
            //////}
            //////catch (FormatException ex)
            //////{
            //////    Console.WriteLine("You must enter numerical value");
            //////    Console.WriteLine(ex.Message);
            //}
            catch(Exception ex)
            {
                Console.WriteLine("Bir hata oluştu");
                Console.WriteLine(ex.Message);
            }finally 
            {
                Console.WriteLine("Finally bloğu çalıştı");
            }
            
            Console.ReadLine();
        }
    }
}
