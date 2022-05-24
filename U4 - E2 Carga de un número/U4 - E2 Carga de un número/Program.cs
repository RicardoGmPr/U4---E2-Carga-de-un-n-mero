using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4___E2_Carga_de_un_número
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            try
            {
                Console.Write("Indique un numero: "); 
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(num1, 2)); 
                Console.ReadKey();
            }
            catch(FormatException)
            {
                Console.WriteLine("Tiene que ingresar un número entero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número ingresado es demasiado grande");
            }
            finally
            {

            }       
        }
    }
}
