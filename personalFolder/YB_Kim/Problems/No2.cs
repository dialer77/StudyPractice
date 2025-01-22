using System.Linq;

namespace YB_Kim.Problems
{

    public class No2
    {
        //https://school.programmers.co.kr/learn/courses/30/lessons/154539
        public int[] solution(int[] numbers)
        {
            int nLength = numbers.Length;
            
            int[] answer = new int[nLength];

            List<int> listNumbers = numbers.ToList();

            for(int i = 0; i < nLength; i++)
            {
                if(listNumbers[i] >= listNumbers.Skip(i).Max() || i == nLength - 1)
                {
                    answer[i] = -1;
                }
                else
                {
                    answer[i] = (from q in listNumbers.Skip(i) where q > listNumbers[i] select q).First();
                }
            }
            
            return answer;
        }
    }
}