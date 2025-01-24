using System.Dynamic;

namespace KY_Kwon.Problems
{
    public class No3
    {
        //https://school.programmers.co.kr/learn/courses/30/lessons/12909
        public bool solution(string s)
        {
            int openCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    openCount++;
                }
                else
                {
                    if (openCount == 0)
                    {
                        return false;
                    }
                    openCount--;
                }
            }
            return openCount == 0;
        }
    }
}