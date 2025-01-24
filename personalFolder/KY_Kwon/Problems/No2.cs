using System.Dynamic;

namespace KY_Kwon.Problems
{
    public class No2
    {
        //https://school.programmers.co.kr/learn/courses/30/lessons/12939
        public string solution(string s)
        {
            string[] strNumbers = s.Split(' ');
            int[] numbers = Array.ConvertAll(strNumbers, int.Parse);
            int min = numbers.Min();
            int max = numbers.Max();

            return $"{min} {max}";
        }
    }
}