using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_LFVV_1244416_E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int cien, cincuenta, veinte, diez, cinco, uno,C25,C1;

            Console.WriteLine("Luis Vega - 1244416");
            Console.Write("Ingrese un numero: ");
            valor= double.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (valor>=0 && valor<=999.99)
            {
                cien = Convert.ToInt32(valor / 100);
                if ((cien * 100) > valor){ cien = cien - 1; }
                valor= valor - (cien * 100);
                cincuenta = Convert.ToInt32(valor / 50);
                if ((cincuenta * 50) > valor) { cincuenta = cincuenta - 1; }
                valor = valor - (cincuenta * 50);
                veinte = Convert.ToInt32(valor / 20);
                if ((veinte * 20) > valor) { veinte = veinte - 1; }
                valor = valor - (veinte * 20);
                diez = Convert.ToInt32(valor / 10);
                if ((diez * 10) > valor) { diez = diez - 1; }
                valor = valor - (diez * 10);
                cinco = Convert.ToInt32(valor / 5);
                if ((cinco * 5) > valor) { cinco = cinco - 1; }
                valor = valor - (cinco * 5);
                uno = Convert.ToInt32(valor / 1);
                if ((uno * 1) > valor) { uno = uno - 1; }
                valor = valor - (uno * 1);
                C25 = Convert.ToInt32(valor / 0.25);
                if ((C25 * 0.25) > valor) { C25 = C25 - 1; }
                valor = valor - (C25 * 0.25);
                C1 = Convert.ToInt32(valor / 0.01);

                Console.WriteLine(cien + " de Q100");
                Console.WriteLine(cincuenta + " de Q50");
                Console.WriteLine(veinte + " de Q20");
                Console.WriteLine(diez + " de Q10");
                Console.WriteLine(cinco + " de Q5");
                Console.WriteLine(uno + " de Q1");
                Console.WriteLine(C25 + " de 25 centavos");
                Console.WriteLine(C1 + " de 1 centavo");
            }

            else
            {
                Console.WriteLine("El valor debe estar entre 0 y 999.99");
            }
            Console.ReadKey();
        }
    }
}
