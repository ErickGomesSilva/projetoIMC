using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double peso;
            double altura;
           
            
            Console.WriteLine("Informe seu peso");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe sua Altura");
            altura = Convert.ToDouble(Console.ReadLine());      


            Console.WriteLine("IMC: " + (peso / (altura * altura)));
            Console.ReadKey();




        }
    }
}
