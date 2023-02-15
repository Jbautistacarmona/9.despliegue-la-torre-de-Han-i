using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.despliegue_la_torre_de_Hanói
{
    internal class Program
    {
        static void Main(string[] args) //significa que el método está asociado con la clase, no con una instancia específica (objeto) de esa clase.
        {

            Console.Write("Ingrese la cantidad de discos: ");
            int cantidadDiscos = Convert.ToInt32(Console.ReadLine());//Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.

            ResolverTorreHanoi(cantidadDiscos, 'A', 'C', 'B');

            Console.ReadLine();
        }

        static void ResolverTorreHanoi(int n, char origen, char destino, char auxiliar) //significa que el método está asociado con la clase, no con una instancia específica (objeto) de esa clase.
        {
            if (n == 1)
            {
                Console.WriteLine("Mover disco 1 desde " + origen + " hacia " + destino);
                return;
            }

            ResolverTorreHanoi(n - 1, origen, auxiliar, destino);

            Console.WriteLine("Mover disco " + n + " desde " + origen + " hacia " + destino);

            ResolverTorreHanoi(n - 1, auxiliar, destino, origen);
        }
    }
}
