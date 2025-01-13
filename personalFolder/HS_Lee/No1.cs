using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS_Lee
{
    // https://www.acmicpc.net/problem/1000
    public class No1000
    {
        private int[] m_inputs = null;
        public No1000(int[] inputs) 
        { 
            m_inputs = inputs;
        }

        public int Solve()
        {
            int result = 0;
            
            result = m_inputs[0] + m_inputs[1];

            return result;
        }
    }

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

            b = Math.Abs(m_inputs[0]-m_inputs[3]);
            h = Math.Abs(m_inputs[1]-m_inputs[4]);
            c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

            if(m_inputs[2] + m_inputs[5] == c)
                result = 1;
            else if(m_inputs[2] + m_inputs[5] > c && Math.Abs(m_inputs[2] - m_inputs[5]) < c)
                result = 2;
            else if(m_inputs[2] + m_inputs[5] < c || Math.Abs(m_inputs[2] - m_inputs[5]) > c)
                result = 0;
            else
                result = -1;

            return result;
        }
    }
    public class No1004
    {
        //https://www.acmicpc.net/problem/1004
        private int[] m_inputs = null;
        public No1004(int[] inputs) 
        { 
            m_inputs = inputs;
        }

        public int[] Solve()
        {
            int T = m_inputs[0];

            int X_Start, Y_Start, X_End, Y_End; //Start, End
            double b, h, c; //base, Height, Hypotenuse

            int nPlanetCnt;
            int[,] nPlanetPos = new int[50,3];

            int nCntArray = 1;
            int[] result = new int[T];

            for(int i = 0; i < T; i++)
            {
                X_Start = m_inputs[nCntArray++];
                Y_Start = m_inputs[nCntArray++];
                X_End = m_inputs[nCntArray++];
                Y_End = m_inputs[nCntArray++];
                nPlanetCnt = m_inputs[nCntArray++];

                for(int j = 0; j < nPlanetCnt; j++)
                {
                    nPlanetPos[j,0] = m_inputs[nCntArray++];
                    nPlanetPos[j,1] = m_inputs[nCntArray++];
                    nPlanetPos[j,2] = m_inputs[nCntArray++];

                    for(int k = 0; k < 2; k++)
                    {
                        b = k == 0? Math.Abs(X_Start - nPlanetPos[j,0]) : Math.Abs(X_End - nPlanetPos[j,0]);
                        h = k == 0? Math.Abs(Y_Start - nPlanetPos[j,1]) : Math.Abs(Y_End - nPlanetPos[j,1]);
                        c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

                        if(c <= nPlanetPos[j,2])
                            result[i]++;
                    }
                }
            }

            return result;
        }
    }
}