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

        //No. 1000
        inputs = new int[] { 1, 2 };
        HS_Lee.No1000 no1000 = new HS_Lee.No1000(inputs);
        Console.WriteLine($"input: {String.Join(", ", inputs)}");
        Console.WriteLine("output: " + no1000.Solve().ToString());

        //NO. 1002
        inputs = new int[] { 0, 0, 13, 40, 0, 37 };
        HS_Lee.No1002 no1002 = new HS_Lee.No1002(inputs);
        Console.WriteLine($"input: {String.Join(", ", inputs)}");
        Console.WriteLine("output: " + no1002.Solve().ToString());

    }
}
