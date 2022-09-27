using System;
using LinearAlgebra;
namespace VectorDemo
{

    /// <summary>Тестовый класс для демонстрирования функциональности вектора.</summary>
    internal static class VectorDemo
    {
        private static void Main()
        {
            var vector1 = new MathVector(new double[] { 1, 2, 3 });
            var vector2 = new MathVector(new double[] { -1, -2, -3 });
            var vector3 = new MathVector(new double[] { 4, 0, 6, 7 });

            Console.WriteLine($"Векторы: {vector1}, {vector2}, {vector3}");

            try
            {
                Console.WriteLine("\nvector1[0]: " + vector1[0]);
                Console.WriteLine("vector1[-1]: ");
                Console.WriteLine(vector1[-1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString().Substring(0,31));
            }

            try
            {
                Console.WriteLine("\nvector1 + vector2: " + (vector1 + vector2));
                Console.WriteLine("vector1 + 5: " + (vector1 + 5));
                Console.WriteLine("vector1 + vector3: ");
                Console.WriteLine(vector1 + vector3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString().Substring(0,44));
            }

            try
            {
                Console.WriteLine("\nvector1 - vector2: " + (vector1 - vector2));
                Console.WriteLine("vector1 - 5: " + (vector1 - 5));
                Console.WriteLine("vector2 - vector3: ");
                Console.WriteLine(vector2 - vector3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString().Substring(0,44));
            }

            try
            {
                Console.WriteLine("\nvector1 * vector2: " + (vector1 * vector2));
                Console.WriteLine("vector1 * 5: " + (vector1 * 5));
                Console.WriteLine("vector1 * vector3: ");
                Console.WriteLine(vector1 * vector3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString().Substring(0,44));
            }

            try
            {
                Console.WriteLine("\nvector1 / vector2: " + (vector1 / vector2));
                Console.WriteLine("vector1 / 5: " + (vector1 / 5));
                Console.WriteLine("vector1 / vector3: ");
                Console.WriteLine(vector1 / vector3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString().Substring(0,44));
            }

            try
            {
                Console.WriteLine("vector1 / 0: ");
                Console.WriteLine(vector1 / 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString().Substring(0,44));
            }

            Console.WriteLine($"\nvector1.ScalarMultiply(vector2): {vector1.ScalarMultiply(vector2)}");
            Console.WriteLine($"vector1.CalcDistance(vector2): {vector1.CalcDistance(vector2)}");
            Console.WriteLine($"\nВекторы (не изменились): {vector1}, {vector2}, {vector3}");
        }
    }
}