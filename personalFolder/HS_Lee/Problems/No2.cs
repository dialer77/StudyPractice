namespace HS_Lee.Problems
{

    public class No2
    {

        //https://school.programmers.co.kr/learn/courses/30/lessons/140108
        public int solution(string s)
        {
        int answer = 0;
        int nCnt1 = 0;
        int nCnt2 = 0;
        
        char FirstChar = s[0];
        
        while(s.Length > 0)
        {
            
            if(FirstChar == s[0])
                nCnt1++;
            else
                nCnt2++;
            
            s = s.Substring(1);    
            
            if(s.Length == 0 && nCnt1 != nCnt2)
                answer++;
            
            if(nCnt1 == nCnt2)
            {
                answer++;
                if (s.Length > 0)
                    FirstChar = s[0];
            }    
            
        }
        
        return answer;
        }
    }
}