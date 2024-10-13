using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int[]> Listo = new List<int[]>();
        Listo.Add(new int[] { 4, 1, 2, 3 }); // Debe dar 6
        Listo.Add(new int[] { 1, 2, 3, 2, 1, 5 }); // Debe dar 7
        Listo.Add(new int[] { 1000000000, 1, 2, 2, 100000000, 1, 1000000000 }); // Debe dar 2999999998
        Listo.Add(new int[] { 1, 2, 3, 3, 2, 1, 5 }); // Debe dar 7
        Listo.Add(new int[] { 5, 1 }); // Debe dar 4
        Listo.Add(new int[] { 1, 5 }); // Debe dar 5

        // Recorrer cada lista y calcular la ganancia máxima
        foreach (var lista in Listo)
        {
            ObtenerPuntosDeInflexion(lista);
            CalcularGananciaMaxima(lista);
        }
    }

    static void ObtenerPuntosDeInflexion(int[] lista)
    {
        List<int> puntosDeInflexion = new List<int>();
        bool vendi = false;
        // Se necesita al menos 3 elementos para tener puntos de inflexión
        // Siempre tengo q empezar vendiendo porq tengo un solo item
        // Tengo q terminar vendiendo para ganar no me voy a quedar con el item

        try
        {
            if (lista.Length < 3)
            {
                //solo alcanzo a vender en cualquier caso
                if (lista[0] > lista[1])
                    puntosDeInflexion.Add(lista[0]);
                else
                    puntosDeInflexion.Add(lista[1]);
                return;
            }
            for (int i = 0; i < lista.Length; i++)
            {
                // Si es el primer item compro solo si es mayor q el siguiente
                if (i == 0 && lista[i] > lista[i + 1])
                {
                    puntosDeInflexion.Add(lista[i]);
                    vendi = true;
                }
                // Si es un punto de inflexión alto vendo
                else if (i > 0 && i < lista.Length - 1 && vendi == false && lista[i] > lista[i - 1] && lista[i] > lista[i + 1])
                {
                    //Son positivos porq los vendo
                    puntosDeInflexion.Add(lista[i]);
                    vendi = true;
                }
                // Si es un punto de inflexión bajo compro
                else if (i > 0 && i < lista.Length - 1 && vendi == true && lista[i] < lista[i - 1] && lista[i] < lista[i + 1])
                {
                    //Son negativos porq compro
                    puntosDeInflexion.Add(-lista[i]);
                    vendi = false;
                }
            }
            // Si el último elemento es mayor que el penúltimo y no es inflexión baja
            if (lista[lista.Length - 1] > lista[lista.Length - 2] && vendi == false)
            {
                puntosDeInflexion.Add(lista[lista.Length - 1]);
            }
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            // Mostrar los puntos de inflexión y la salida sumada
            Console.WriteLine("Lista original: " + string.Join(", ", lista));
            Console.WriteLine("Puntos de Inflexión: " + string.Join(", ", puntosDeInflexion));
            Console.WriteLine("Suma: " + puntosDeInflexion.Sum());
            Console.WriteLine("_____________________________________________________________");
        }
    }

    static void CalcularGananciaMaxima(int[] lista)
    {
        int suma = 0;
        try
        {
            bool vendi = false;
            if (lista.Length == 2)
            {
                suma = Math.Max(lista[0], lista[1]);
                return;
            }
            for (int i = 0; i < lista.Length; i++)
            {
                if (i == 0 && lista[i] > lista[i + 1])
                {
                    suma += lista[i];
                    vendi = true;
                }
                else if (i > 0 && i < lista.Length - 1 && !vendi && lista[i] > lista[i - 1] && lista[i] > lista[i + 1])
                {
                    suma += lista[i];
                    vendi = true;
                }
                else if (i > 0 && i < lista.Length - 1 && vendi && lista[i] < lista[i - 1] && lista[i] < lista[i + 1])
                {
                    suma -= lista[i];
                    vendi = false;
                }
            }
            if (!vendi && lista[lista.Length - 1] > lista[lista.Length - 2])
            {
                suma += lista[lista.Length - 1];
            }
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            Console.WriteLine("Ganancia Máxima: " + suma);
            Console.WriteLine("___________________________");
        }
    }
}

