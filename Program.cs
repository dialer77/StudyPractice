public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("GJ_Ryu");
        Console.WriteLine("No1 - https://www.acmicpc.net/problem/1085");
        
        int[] inputs = new int[] { 6, 2, 10, 3 };
        GJ_Ryu.No1 no1 = new GJ_Ryu.No1(inputs);

        Console.WriteLine($"input: {String.Join(", ", inputs)}");
        Console.WriteLine("output: " + no1.Solve().ToString());

    }
}
