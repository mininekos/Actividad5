using System;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {
            return String.Join("", vs);
            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {
            Array.Sort(vs); ;
            return String.Join("", vs);
            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {
            int cont = 0;
            Char[] carateres;
            for (int ind = 0; ind < vs.Length; ind++)
            {
                carateres = vs[ind].ToCharArray(0, vs[ind].Length);
                for (int ind2 = 0; ind2 < carateres.Length; ind2++)
                {
                    if (carateres[ind2] == v) {
                        cont++;
                    }
                }
            }
            return cont;
            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            int[] suma=new int[vs1.Length];
            for (int ind = 0; ind < vs1.Length; ind++) {
                suma[ind] = vs1[ind] + vs2[ind];
            }
            return suma;
            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            int[] multiplicacion = new int[vs1.Length];
            for (int ind = 0; ind < vs1.Length; ind++)
            {
                multiplicacion[ind] = vs1[ind] * vs2[ind];
            }
            return multiplicacion;
            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            //TODO

            throw new NotImplementedException();


        }

        public static int contarPalabras(string entrada)
        {
            //TODO

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            //TODO

            throw new NotImplementedException();
        }
    }
}
