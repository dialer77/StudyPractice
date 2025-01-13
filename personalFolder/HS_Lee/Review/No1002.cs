using System.Reflection;

namespace HS_Lee.Review
{
    public class No1002
    {
        // public static void Main()
        // {
        //     string strTestCount = Console.ReadLine()!;
        //     int testCount = int.Parse(strTestCount);
        //     int[] testResult = new int[testCount];
        //     No1002 no1002 = new No1002();
        //     for (int i = 0; i < testCount; i++)
        //     {
        //         string inputLine = Console.ReadLine()!;
        //         string[] strInputs = inputLine.Split(' ');
        //         int[] inputs = new int[strInputs.Length];
        //         for (int j = 0; j < strInputs.Length; j++)
        //         {
        //             inputs[j] = int.Parse(strInputs[j]);
        //         }

        //         testResult[i] = no1002.Solve(inputs);

        //     }

        //     for (int i = 0; i < testResult.Length; i++)
        //     {
        //         Console.WriteLine(testResult[i]);
        //     }
        // }

        //https://www.acmicpc.net/problem/1002

        public int Solve(int[] inputs)
        {
            int result = 0;
            int pointX1 = inputs[0];
            int pointY1 = inputs[1];
            int radius1 = inputs[2];

            int pointX2 = inputs[3];
            int pointY2 = inputs[4];
            int radius2 = inputs[5];

            double pointDistance = Math.Pow(pointX1 - pointX2, 2) + Math.Pow(pointY1 - pointY2, 2);
            double radiusSum = Math.Pow(radius1 + radius2, 2);
            double radiusSub = Math.Pow(radius2 - radius1, 2);

            // 점의 위치가 같을경우
            if (pointDistance == 0)
            {
                // 거리가 같으면 원의 둘레전체 무한대의 좌표
                if (radius1 == radius2)
                {
                    result = -1;
                }
                // 거리가 다르면 겹치는 좌표가 없음
                else
                {
                    result = 0;
                }

            }
            // 큰원안에 작은 원이 들어갈때
            else if (pointDistance < radiusSub)
            {
                result = 0;

            }
            // 큰원안에 작은원이 접할때
            else if (pointDistance == radiusSub)
            {
                result = 1;
            }
            // 두개의 원이 떨어져있을때
            else if (pointDistance > radiusSum)
            {
                result = 0;
            }
            // 두개의 원이 밖에서 접할때
            else if (pointDistance == radiusSum)
            {
                result = 1;
            }
            // 두개의 원이 겹칠때
            else if (pointDistance < radiusSum)
            {
                result = 2;
            }

            return result;
        }
    }
}