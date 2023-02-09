
using System;

public class Task64 {

    // функция рекурсивно выводит натуральные числа в порядке убывания
    public static void recNat(int N) {
        // если число равно нулю - выйти из функции
        if (N == 0) return;
        // вывести на экран очередное число
        Console.Write(N + " ");
        // вызывть эту функцию для числа на единицу меньше
        recNat(N - 1);
    }

    public static void Main(string[] args) {
        // вывод сообщения на экран
        Console.WriteLine("Введите N:");
        // чтение введеной строки 
        int N = Convert.ToInt32(Console.ReadLine());
        // вызов функции
        recNat(N);
    }
}