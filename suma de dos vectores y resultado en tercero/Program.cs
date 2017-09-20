using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_de_dos_vectores_y_resultado_en_tercero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la longitud de los vectores");
            //declaramos la logitud de los vectores
            int n = Convert.ToInt32(Console.ReadLine());
            //decalaramos los vectores
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];
            Console.WriteLine("Ingresando valores al vector A");
            //almacenamos valores en A
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            //almacenamos valores en B
            Console.WriteLine("Ingresando valores al vector B");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                B[j] = Convert.ToInt32(Console.ReadLine());
            }
            //Sumamos los componentes
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
            }
            //Imprimimos la suma
            Console.WriteLine("La suma de los vectores es: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("[" + C[i] + "] ");
            }
            Console.ReadKey();
        }
    }
}
