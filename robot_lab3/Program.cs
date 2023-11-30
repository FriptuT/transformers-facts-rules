using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoBot[] autoBots = new AutoBot[4];
            autoBots[0] = new AutoBot("Optimus Prime", "Bumblebee", "Megatron");
            autoBots[1] = new AutoBot("Optimus Prime", "Arcee", "Megatron");
            autoBots[2] = new AutoBot("Bulkhead", "Miko Nakadai", "Starscream ");
            autoBots[3] = new AutoBot("Bulkhead", "Raf Esquivel", "Soundwave ");

            Decepticon[] decepticons = new Decepticon[4];
            decepticons[0] = new Decepticon("Megatron", "Starscream", "Optimus Prime");
            decepticons[1] = new Decepticon("Megatron", "Knock Out", "Bulkhead");
            decepticons[2] = new Decepticon("Soundwave", "Skyquake", "Starscream ");
            decepticons[3] = new Decepticon("Soundwave", "Makeshift", "Soundwave ");

            Prieteni[] prieteniBuni = functieArrayPrieteni(autoBots);
            Console.WriteLine("Prieteni buni:");
            foreach (var prieten in prieteniBuni)
            {
                Console.Write($"{prieten.prieten1} , {prieten.prieten2}\n ,");
            }
            Console.WriteLine();



            Prieteni[] prieteniRai = functieArrayPrieteni(decepticons);
            Console.WriteLine("Prieteni rai:");
            foreach (var prieten in prieteniRai)
            {
                Console.Write($"{prieten.prieten1} , { prieten.prieten2}, \n");
            }
            Console.WriteLine();

            AutoBot[] autoBotsD = new AutoBot[4];
            autoBotsD[0] = new AutoBot("Optimus Prime", "Bumblebee", "Megatron");
            autoBotsD[1] = new AutoBot("Bulkhead", "Arcee", "Megatron");
            autoBotsD[2] = new AutoBot("BumbleBee", "Miko Nakadai", "Starscream ");
            autoBotsD[3] = new AutoBot("Arcee", "Raf Esquivel", "Soundwave ");

            Decepticon[] decepticonsD = new Decepticon[4];
            decepticonsD[0] = new Decepticon("Megatron", "Starscream", "Optimus Prime");
            decepticonsD[1] = new Decepticon("Starscream", "Knock Out", "Bulkhead");
            decepticonsD[2] = new Decepticon("Knock Out", "Skyquake", "BumbleBee ");
            decepticonsD[3] = new Decepticon("Makeshift", "Makeshift", "Arcee ");






            Dusmani[] dusmani = functieArrayDusmani(autoBotsD, decepticonsD);
            Console.WriteLine("Perechi de dusmani");
            foreach (var dusman in dusmani)
            {
                Console.WriteLine($"{dusman.dusman1} si {dusman.dusman2} ");
            }
            Console.WriteLine("===================");

            Console.ReadLine();
        }

        static Prieteni[] functieArrayPrieteni(AutoBot[] autoBots)
        {
            var listaPrieteni = new List<Prieteni>();

            for (int i = 0; i < autoBots.Length; i++)
            {
                for (int j = i+1; j < autoBots.Length; j++ )
                {
                    if (autoBots[i].autoBot == autoBots[j].autoBot)
                    {
                        var prieten = new Prieteni(autoBots[i].partener, autoBots[j].partener);
                        listaPrieteni.Add(prieten);
                    }
                }
            }
            return listaPrieteni.ToArray();
        }

        static Prieteni[] functieArrayPrieteni(Decepticon[] decepticons)
        {
            var listaPrieteni = new List<Prieteni>();

            for (int i = 0; i < decepticons.Length; i++)
            {
                for (int j = i + 1; j < decepticons.Length; j++)
                {
                    if (decepticons[i].decepticon == decepticons[j].decepticon)
                    {
                        var prieten = new Prieteni(decepticons[i].partener, decepticons[j].partener);
                        listaPrieteni.Add(prieten);
                    }
                }
            }
            return listaPrieteni.ToArray();
        }

        static Dusmani[] functieArrayDusmani(AutoBot[] autoBotsD, Decepticon[] decepticonsD)
        {
            var listaDusmani = new List<Dusmani>();

            for (int i = 0; i < autoBotsD.Length; i++)
            {
                for (int j = 0; j < decepticonsD.Length; j++)
                {
                    if (autoBotsD[i].autoBot == decepticonsD[j].dusmanDirect)
                    {
                        var dusman = new Dusmani(autoBotsD[i].autoBot, decepticonsD[j].decepticon);
                        listaDusmani.Add(dusman);
                    }
                }
            }
            return listaDusmani.ToArray();
        }
    }
}
