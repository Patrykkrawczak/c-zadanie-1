using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    public class ParaLiczb
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public ParaLiczb(double value1, double value2)
        {
            this.Value1 = value1;
            this.Value2 = value2;
        }
    }
 
    public class Dzialanie
    {
        public double Rezultat { get; set; }
        public Dzialanie(double rezultat) 
        {
            this.Rezultat = rezultat;
        }
    }
    public class Wynik
    {
        public Dzialanie Dodawanie { get; set; }
        public Dzialanie Odejmowanie { get; set; }
        public Dzialanie Mnozenie { get; set; }
        public Dzialanie Dzielenie { get; set; }

        public ParaLiczb ParaLiczb { get; set; }

        public Wynik(Dzialanie dodawanie, Dzialanie odejmowanie, Dzialanie mnozenie, Dzialanie dzielenie, ParaLiczb paraliczb)
        {
            this.Dzielenie = dzielenie;
            this.Dodawanie = dodawanie;
            this.Mnozenie = mnozenie;
            this.Odejmowanie = odejmowanie;
            this.ParaLiczb = paraliczb;
        }
    }
}
