using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Readonly_test001
{
    class Program
    {
        public const int ThisIsConst = 10;//Const - w trakcie kompilacji
        public static readonly double ThisIsReadOnly = 99.66;//ReadOnly - runtime

        public const string MyKey = "MyKey";
        public static readonly double betterPI = Math.PI;

        static Program()
        {
            ThisIsReadOnly = 10.11;
            betterPI = Convert.ToDouble(ConfigurationManager.AppSettings[MyKey], CultureInfo.InvariantCulture);
        }

        static void Main(string[] args)
        {
            
        }
    }
}
