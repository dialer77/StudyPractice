namespace GW_Lee.Problems
{

    public class No2
    {

        //https://school.programmers.co.kr/learn/courses/30/lessons/140108
        public int solution(string s)
        {
            int answer = 0;
            int count = 0;
            int othercount = 0;
            char c = s[0]; 

        for (int i = 0; i < s.Length; i++) 
        { 
            if (count == othercount) 
            {
                answer++;
                c = s[i]; 
            }
        

        if (c == s[i]) count++; 

        else othercount++;
        }
        
        return answer;
    }
}