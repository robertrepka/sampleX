using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sampleX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var ci = new System.Globalization.CultureInfo("sv-SE");
            //System.Globalization.CultureInfo initialCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            //System.Globalization.CultureInfo testCulture = System.Globalization.CultureInfo.CreateSpecificCulture("sk-SK");

            ci.NumberFormat.CurrencyDecimalDigits = 2;
            ci.NumberFormat.CurrencyDecimalSeparator = ",";
            ci.NumberFormat.CurrencyGroupSeparator = " ";
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
