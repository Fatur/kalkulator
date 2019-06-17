using System;

namespace Calculator
{
    public class Kalkulator
    {
        private int m_result=0;
        private bool m_isOpsPenjumlahan=true;
        public void Input(int input)
        {
            if(m_isOpsPenjumlahan)
                m_result=m_result+input;
            else
                m_result=m_result-input;
        }

        public void Tambah()
        {
            m_isOpsPenjumlahan=true;
        }

        public int Output()
        {
            return m_result;
        }

        public void Kurang()
        {
            m_isOpsPenjumlahan=false;
        }

        public void Reset()
        {
            m_isOpsPenjumlahan=true;
            m_result=0;
        }
    }
}
