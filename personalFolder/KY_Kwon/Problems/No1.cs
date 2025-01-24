using System.Dynamic;

namespace KY_Kwon.Problems
{
    public class No1
    {
        //https://school.programmers.co.kr/learn/courses/30/lessons/12953
        public int solution(int[] arr)
        {
            int answer = arr[0];

            // 배열의 모든 수에 대해 순차적으로 최소공배수 계산
            for (int i = 1; i < arr.Length; i++)
            {
                answer = CalculateLeastCommonMultiple(answer, arr[i]);
            }

            return answer;
        }

        // 최대공약수 계산
        private int CalculateGreatestCommonDivisor(int dividend, int divisor)
        {
            while (divisor != 0)
            {
                int temp = divisor;
                divisor = dividend % divisor;
                dividend = temp;
            }
            return dividend;
        }

        // 최소공배수 계산
        private int CalculateLeastCommonMultiple(int a, int b)
        {
            int dividend = Math.Max(a, b);
            int divisor = Math.Min(a, b);
            return (a * b) / CalculateGreatestCommonDivisor(dividend, divisor);
        }
    }
}