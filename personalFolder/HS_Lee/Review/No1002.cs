namespace HS_Lee.Review
{
    public class No1002
    {
        //https://www.acmicpc.net/problem/1002
        private int[] m_inputs = null;
        public No1002(int[] inputs)
        {
            m_inputs = inputs;
        }

        public int Solve()
        {
            int result = 0;
            double b, h, c; //base, Height, Hypotenuse

            b = Math.Abs(m_inputs[0] - m_inputs[3]);
            h = Math.Abs(m_inputs[1] - m_inputs[4]);
            c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

            if (m_inputs[2] + m_inputs[5] == c)
                result = 1;
            else if (m_inputs[2] + m_inputs[5] > c && Math.Abs(m_inputs[2] - m_inputs[5]) < c)
                result = 2;
            else if (m_inputs[2] + m_inputs[5] < c || Math.Abs(m_inputs[2] - m_inputs[5]) > c)
                result = 0;
            else
                result = -1;

            return result;
        }
    }
}