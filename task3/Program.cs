// (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.
public class Program {

    public static void Main(){
        Console.WriteLine("введите числа через запятую:");

        string? s = Console.ReadLine();
        if (s == null) {
            return;
        }

        string[] strings = s.Split(',');
        int[] nums = new int[strings.Length];
        int i = 0;
        foreach (string str in strings) {
            nums[i++] = Convert.ToInt32(str);
        }

        foreach (int num in nums) {
            Console.WriteLine(num);
        }
    }
}
