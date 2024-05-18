using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Apps_Razor_1._1.Pages
{
    public class ProgramaCuatroModel : PageModel
    {

        public int[] numeros = new int[20];
        public int[] ordenados = new int[20];
        public int suma = 0;
        public int media = 0;
        public string moda;
        public double mediana = 0;
        
        public void OnPost()
        {
            Random random = new Random();
            for (int i = 0; i < numeros.Length; i++) 
            {
                numeros[i] = random.Next(100);
            }

            ordenados = numeros.OrderBy(n => n).ToArray();

            // Realizar la suma
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }

            // Realizar la media aritmetica
            for (int i = 0; i < numeros.Length; i++)
            {
                media = suma / numeros.Length;
            }

            // Realizar el calculo de la mediana
            mediana = calcularMediana(numeros);

            // Realizar el calculo de la moda
            List<int> moda_calculada = calcularModa(numeros);
            moda = string.Join(", ", moda_calculada);
        }

        static double calcularMediana(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();
            Array.Sort(sortedNumbers);

            int size = sortedNumbers.Length;
            int mid = size / 2;

            if (size % 2 == 0)
            {
                // Si el tamaño es par, la mediana es el promedio de los dos números del medio
                return (sortedNumbers[mid - 1] + sortedNumbers[mid]) / 2.0;
            }
            else
            {
                // Si el tamaño es impar, la mediana es el número del medio
                return sortedNumbers[mid];
            }
        }

        static List<int> calcularModa(int[] numbers)
        {
            var frequency = new Dictionary<int, int>();

            // Contar la frecuencia de cada número
            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            // Encontrar la(s) moda(s)
            int maxFrequency = frequency.Values.Max();
            List<int> modas = frequency
                .Where(pair => pair.Value == maxFrequency)
                .Select(pair => pair.Key)
                .ToList();

            return modas;
        }
    }
}
