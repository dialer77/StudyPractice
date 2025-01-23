namespace GW_Lee.Problems
{

    public class No3
    {

        //https://school.programmers.co.kr/learn/courses/30/lessons/12921
       public int solution(int n) {
        int answer = 0;
        
        for(int i = 2; i <= n; i++) // 2부터
        {
            if(checksosu(i) == true)
            {
                answer++;
            }
        }
        return answer;
    }
    
    public bool checksosu(int u)
    {
        bool numCheck = true;
        
        for(int i = 2; i * i <= u; i++)
        {
            if(u % i == 0) //
            {
                numCheck = false;
                break;
            }
        }
        return numCheck;
    }
}