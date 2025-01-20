namespace HS_Lee.Problems
{

    public class No3
    {

        //https://school.programmers.co.kr/learn/courses/30/lessons/12921
        public int solution(int n)
        {
            int answer = 0;
            for(int i = 2; i <= n; i++)
            {
                bool bIsPrime = true;
                for(int j = 2; j * j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        bIsPrime = false;
                        break;
                    }
                }
                if(bIsPrime)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}