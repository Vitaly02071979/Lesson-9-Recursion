
using System;

public class Task68 {

    // функция рекурсивно вычисляет функцию Аккермана
    public static int recAcc(int M, int N) {
        // если M = 0, то вернуть N + 1
        if (M == 0) return N + 1;
        // если M > 0 и N = 0, то вернуть результат вызова функции с параметрами M-1 и 1
        else if (M > 0 && N == 0) return recAcc(M - 1, 1);
        // если M > 0 и N > 0, то вернуть результат вызова функции с параметрами M-1
        // и результатом выполнения функции с параметрами M и N-1
        else if (N > 0 && M > 0) return recAcc(M - 1, recAcc(M, N - 1));
        // если условия не выполняются - вернуть результат 
        return recAcc(N, M);
    }

    public static void Main(string[] args) {
        // вывод сообщений на экран и чтение введенных строк
        Console.WriteLine("Введите неотрицательное число M:");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите неотрицательное число N:");
        int N = Convert.ToInt32(Console.ReadLine());
        // вызов функции и вывод ее результата на экран
        Console.WriteLine(recAcc(M, N));
    }
}