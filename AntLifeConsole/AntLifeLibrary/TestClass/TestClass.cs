using System;
using System.Collections.Generic;
using System.Text;

namespace AntLifeLibrary.TestClass
{
    public class TestClass
    {
        public int TestClassId { get; set; }
        public string TestClassName { get; set; }

        public int polePubliczne;
        private int polePrywatne;
        protected int poleChronione;
        internal int poleWewnętrze;
        protected internal int poleWewnetrzneChronione;

        private static int poleStatyczne;//przydatne w Singleton

        private int naszaKasa;

        public int NaszaKasa
        {
            get { return naszaKasa; }   //bezpieczny sposób pobierania pola
            set                         //bezpieczny sposób ustawiania pola
            {
                if (naszaKasa < 10)
                    naszaKasa = 10;
                else
                    naszaKasa = value;
            }
        }

        private int wiek;//zmienna oddzielona od dostępu

        public int GetAge()
        {
            return wiek;
        }

        public void SetAge(int wiek)
        {
            this.wiek = wiek;
        }

        public int Wiek
        {
            get { return wiek; }
            set { this.wiek = value; }
        }


    }
}
