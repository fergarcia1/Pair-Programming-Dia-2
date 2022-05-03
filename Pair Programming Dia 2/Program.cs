using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Dia_2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("(1) Ejercicio 1");
                Console.WriteLine("(2) Ejercicio 2");
                Console.WriteLine("(3) Ejercicio 3");
                Console.WriteLine("(0) Salir");
                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //Crea un programa que pida al usuario 5 números reales de doble precisión,
                        //los guarde en una cola y luego los muestre en pantalla.

                        Console.Clear();
                        Queue cola = new Queue();
                        try
                        {
                            Console.WriteLine("Introduzca 5 numeros reales en su Cola: ");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("Numero " + (i + 1) + " : ");
                                cola.Enqueue(double.Parse(Console.ReadLine()));
                            }
                            mostrarCola(cola);
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {
                            Console.Write("Dato invalido!");
                            Console.ReadKey();
                            Main();
                        }
                        break;
                    case 2:
                        //Crear un programa que cargue una pila de enteros, luego dividir los datos de la pila en dos pilas diferentes,
                        //aquellos mayores a 20 y otra para los menores a 20

                        Console.Clear();
                        Stack pila = new Stack();
                        Stack pilaMenores = new Stack();
                        Stack pilaMayores = new Stack();

                        pila = cargarPila(pila);
                        int cantidadPila = pila.Count;
                        for (int i = 0; i < cantidadPila; i++)
                        {
                            int num = (int)pila.Pop();
                            if (num < 20)
                            {
                                pilaMenores.Push(num);
                            }
                            else
                            {
                                pilaMayores.Push(num);
                            }
                        }
                        Console.WriteLine("******Pila mayores a 20*******");
                        mostrarPila(pilaMayores);
                        Console.WriteLine("******Pila menores a 20*******");
                        mostrarPila(pilaMenores);
                        Console.ReadKey();
                 
                        break;
                    case 3:
                        //Crear un programa que haga una suma de manera recursiva, y luego mostrar el resultado de la suma

                        Console.Clear();
                        int[] array = new int[5];
                        cargaArregloIntRandom(array, 5);
                        int suma = sumaRecursiva(array, 5, 0);
                        Console.WriteLine(suma);
                        for(int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine(array[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Se ha ingresado un dato no valido!");
                Console.ReadKey();
                Main();
            }
        }

        public static Stack cargarPila(Stack pila)
        {
            try
            {
                Console.WriteLine("Introduzca 10 numeros enteros en su Pila: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Numero " + (i + 1) + " : ");
                    pila.Push(int.Parse(Console.ReadLine()));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Dato invalido!");
                Console.ReadKey();
                Main();
            }
            return pila;
        }

        public static void mostrarCola(Queue cola)
        {
            Queue colaAux = cola;
            int cantidadCola = colaAux.Count;
            for (int i = 0; i < cantidadCola; i++)
            {
                double muestra = (double)colaAux.Dequeue();
                Console.WriteLine(muestra);
            }
        }
        public static void mostrarPila(Stack pila)
        {
            Stack pilaAux = pila;
            int cantidadPila = pilaAux.Count;
            for (int i = 0; i < cantidadPila; i++)
            {
                int muestra = (int)pilaAux.Pop();
                Console.WriteLine("| " + muestra + " |");
                Console.WriteLine("-----");
            }
        }


        static int sumaRecursiva(int[] a, int size, int i)
        {
            int suma = 0;
            if (i < size)
            {
                suma = a[i] + sumaRecursiva(a, size, i + 1);
            }
            return suma;
        }

        static void cargaArregloIntRandom(int[] a, int dim)
        {
            Random random = new Random();
            int num;

            for (int i = 0; i < dim; i++)
            {
                num = random.Next(0, 11);
                a[i] = num;
            }
        }
    } 
}
