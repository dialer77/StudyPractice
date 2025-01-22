using System.Diagnostics;
using System.Threading.Channels;

namespace YB_Kim.Problems
{

    public class No1
    {

        //https://school.programmers.co.kr/learn/courses/30/lessons/132267
        public int solution(int a, int b, int n)
        {
            int answer = 0;     // Income 누적

            int nInput = a;     // a개를 주면
            int nOutput = b;    // b개 만큼 돌려줌
            int nVariable = n;  // 투입량

            int nExchange = 0;  // 교환량
            int nChange = 0;    // 잔량

            // a = 2, b = 1, c = 20

            while(true)
            {
                nExchange = (int)(nVariable / nInput) * nOutput;
                nChange = nVariable % nInput;

                answer += nExchange;
                nVariable = nExchange + nChange;

                if(nChange >= nInput)
                {
                    nChange -= nInput;
                    nVariable += nOutput;
                }

                if(nVariable == nInput)
                {
                    answer += nOutput;
                    break;
                }

                //탈출조건
                if(nVariable < nInput) break;
            } 

            return answer;
        }

    }
}