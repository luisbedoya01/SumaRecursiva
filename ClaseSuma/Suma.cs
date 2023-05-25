using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSuma
{
    class Suma
    {
        static int sumaRecursiva(List<int> lista, int indice)
        {
            if(indice == lista.Count)
            {
                return 0;
            }
            return lista[indice] + sumaRecursiva(lista, indice + 1);
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,3,4,5};
            int suma = sumaRecursiva(list, 0);
            Console.WriteLine("El resultado de la suma es: " + suma);
        }
    }

    
}
