// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
public class Program {
    public static int sum(int a) {
        if (a < 0) {
            a = -a;
        }
        
        int result = 0;

        while (a > 0) {
            result += a % 10;
            a = a / 10;
        }

        return result;
    }

    public static void Main(){
        Console.WriteLine("введите число:");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"сумма чисел = " + sum(a));
    }
}

