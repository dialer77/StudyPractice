namespace GW_Lee.Problems
{

    public class No4
    {

        //https://school.programmers.co.kr/learn/courses/30/lessons/340213
        //아래 클래스 구조를 유지 하는 형태로 문제를 풀이해서 작성해주세요
        public static string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            VideoTimer videoTimer = new VideoTimer(video_len, pos, op_start, op_end);

            foreach (string command in commands)
            {
                if (command == "next")
                {
                    videoTimer.next();
                }
                else if (command == "prev")
                {
                    videoTimer.prev();
                }
            }

            return videoTimer.ToString();
        }

        public class VideoTimer
        {
            public VideoTimer(string video_len, string pos, string op_start, string op_end)
            {
            }

            public void next()
            {

            }

            public void prev()
            {

            }
        }
    }
}