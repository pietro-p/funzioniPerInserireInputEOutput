using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int età = Convert.ToInt32(Input.NumeroInt());
            double peso = Convert.ToDouble(Input.NumeroDouble());
            string nome = Convert.ToString(Input.String());
            Output.StampaInt(età);
            Output.StampaDouble(peso);
            Output.StampaString(nome);
        }
    }
}
