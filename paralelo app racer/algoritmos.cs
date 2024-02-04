using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paralelo_app_racer
{
    public class algoritmos
    {
 
            public static bool BusquedaSecuencial(int[] arreglo, int objetivo)
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] == objetivo)
                        return true; // Si encuentra el objetivo, retorna verdadero
                }
                return false; // Si termina el bucle sin encontrar el objetivo, retorna falso
            }

            public static bool BusquedaBinaria(int[] arreglo, int objetivo)
            {
                int izquierda = 0;
                int derecha = arreglo.Length - 1;

                while (izquierda <= derecha)
                {
                    int medio = (izquierda + derecha) / 2;

                    if (arreglo[medio] == objetivo)
                        return true; // Si encuentra el objetivo, retorna verdadero

                    if (arreglo[medio] < objetivo)
                        izquierda = medio + 1; // Si el elemento en el medio es menor que el objetivo, actualiza la izquierda
                    else
                        derecha = medio - 1; // Si el elemento en el medio es mayor que el objetivo, actualiza la derecha
                }

                return false; // Si termina el bucle sin encontrar el objetivo, retorna falso
            }

            public static void Burbuja(int[] arreglo)
            {
                int n = arreglo.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arreglo[j] > arreglo[j + 1])
                        {
                            int temp = arreglo[j];
                            arreglo[j] = arreglo[j + 1];
                            arreglo[j + 1] = temp;
                        }
                    }
                }
            }


            public static void QuickSort(int[] arreglo, int izquierda, int derecha)
            {
                if (izquierda < derecha)
                {
                    int particion = Particionar(arreglo, izquierda, derecha);

                    QuickSort(arreglo, izquierda, particion - 1);
                    QuickSort(arreglo, particion + 1, derecha);
                }
            }

            private static int Particionar(int[] arreglo, int izquierda, int derecha)
            {
                int pivote = arreglo[derecha];
                int i = (izquierda - 1);

                for (int j = izquierda; j < derecha; j++)
                {
                    if (arreglo[j] <= pivote)
                    {
                        i++;

                        int temp = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = temp;
                    }
                }

                int temp1 = arreglo[i + 1];
                arreglo[i + 1] = arreglo[derecha];
                arreglo[derecha] = temp1;

                return i + 1;
            }

            public static void Insercion(int[] arreglo)
            {
                int n = arreglo.Length;
                for (int i = 1; i < n; ++i)
                {
                    int clave = arreglo[i];
                    int j = i - 1;

                    while (j >= 0 && arreglo[j] > clave)
                    {
                        arreglo[j + 1] = arreglo[j];
                        j = j - 1;
                    }

                    arreglo[j + 1] = clave;
                }
            }

        }
    }

