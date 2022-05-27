using System;
using System.Collections.Generic;
using System.Text;

namespace ByronCalderon3A_Ejercicio10
{
    public class Factorial
    {
        private String numero { get; set; }
        private int valor { get; set; }

        private int factorial_comp { get; set; }

        public Factorial()
        {
            this.numero = "";
            this.valor = 0;
            this.factorial_comp = 1;
        }

        public void Proceso_factorial()
        {
            Console.WriteLine("Ingrese un número para realizar el factorial");
            numero = Console.ReadLine();
            valor = Convert.ToInt32(num);
            for (int i = 1; i <= valor; i++)
            {
                factorial_comp *= i;
            }
            Console.WriteLine("El factorial del número elegido (" + valor + ") es: " + factorial_comp);
            Console.ReadKey();
        }
        
    }
}
