using System.Runtime;

namespace YB_Kim.Problems
{

    public class No3
    {
        //https://school.programmers.co.kr/learn/courses/30/lessons/12921
        public int solution(int n)
        {
            int answer = 0;
            int nSqrt = 0;

            for(int i = 0 ; i < n; i++)
            {
                if (Math.Pow(i,2) > n)
                {
                    nSqrt = i;
                    break;
                }
            }
            
            List<int> nList = new List<int>();

            // List 구성
            for(int i = 1; i <= n; i++)
            {
                nList.Add(i);
            }
            
            // 에라토스체네스의 체
            for(int i = 2; i <= nSqrt; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(j >= nList.Count) break;
                    if(i % nList[j] == 0 && i != nList[j])
                    {
                        break;
                    }

                    if(nList[j] % i == 0)
                    {
                        if(nList[j] == i)
                        {
                            continue;
                        }

                        nList.Remove(nList[j]);
                    }
                }
            }

            answer = nList.Count - 1; // 1 != prime

            return answer;
        }
    }
}