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

        //NO. 1004
        inputs = new int[] { 2,
                            -5, 1, 12, 1,
                            7,
                            1, 1, 8,
                            -3, -1, 1,
                            2, 2, 2,
                            5, 5, 1,
                            -4, 5, 1,
                            12, 1, 1,
                            12, 1, 2,
                            -5, 1, 5, 1,
                            1,
                            0, 0, 2};
        HS_Lee.No1004 no1004 = new HS_Lee.No1004(inputs);
        Console.WriteLine($"input: {String.Join(", ", inputs)}");
        Console.WriteLine("output: " + string.Join(", ", no1004.Solve().Select(x => x.ToString())));
    }
}
