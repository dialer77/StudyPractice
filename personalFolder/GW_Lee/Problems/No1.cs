namespace GW_Lee.Problems
{

    public class No1
    {

        //https://school.programmers.co.kr/learn/courses/30/lessons/132267
        public int solution(int a, int b, int n)
        {
            int answer = 0;

            int input = a; // a개당
            int output = b; //  b를 받는 비율율
            int remain = n; // 남은 병 수 

            // 제한사항 1 ≤ b < a ≤ n ≤ 1,000,000

            while( input <= remain )
            {
                answer += (remain/input ) * output;                                              // 20-> 20/2 = 10 ->
                remain = (remain/input) * output + remain % input;                      // 0병  > 10 /2 =5 -> 5/2 2병 , 1 ->  3/2 1 ,1 -> 1병 -> 1<=2  탈출

            }
            return answer;
        }
    }
}