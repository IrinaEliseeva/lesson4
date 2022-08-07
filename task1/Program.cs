// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
public class Program {
    public static int pow(int a, int b) {
        if (b < 0) {
            throw new Exception("b should be >= 0");
        }

        if (b == 0) {
            return 1;
        }

        int result = 1;

        for (int i = 0; i < b; i ++ ) {
            result *= a;
        }

        return result;
    }

    public static void Main(){
        Console.WriteLine("введите 2 числа:");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{a}^{b} = " + pow(a, b));
    }
}
