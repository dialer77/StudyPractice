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
}