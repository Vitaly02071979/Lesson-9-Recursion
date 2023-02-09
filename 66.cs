
using System;

public class Task66 {

    public static void Main(string[] args) {
        // вывод сообщений на экран и чтение введенных строк
        Console.WriteLine("Введите M:");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N:");
        int N = Convert.ToInt32(Console.ReadLine());
        // переменная для суммы чисел
        int sum = 0;
        // цикл от M до N
        for (int i = M; i <= N; i++) {
            // добавление к сумме очередного числа 
            sum += i;
        }
        // вывод результата на экран 
        Console.WriteLine(sum);
    }
}