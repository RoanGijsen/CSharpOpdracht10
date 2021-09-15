using System;
using System.Collections.Generic;

namespace CSharpOpdracht10
{
    

    class Program
    {
        

        static void Main(string[] args)
        {
            Vak vak = new Vak();
            Console.WriteLine("Het woord moet beginnen met de laatste letter van het vorige woord");
            Console.WriteLine("Druk q om te stoppen");
            

            
            vak.VakantieSpullen();

           


        }
       
    }
    public class Vak
    {
        int x = 0;
        List<string> vakantie = new List<string>();
        string resultaat = "";

        public void VakantieSpullen()
        {
            Console.WriteLine("Ik ging op vakantie en ik neem mee?");
            vakantie.Add(Console.ReadLine());

           
            controleerLetters();

       
        }
        public void controleerLetters()
        {
            String[] str = vakantie.ToArray();
            if (str[x] == "q")
            {
                Environment.Exit(0);
            }


            if (x != 0)
            {
                string lastWord = str[x - 1];
                string thisWord = str[x];
                if (thisWord[0] == lastWord[lastWord.Length - 1] || x == 0)
                {
                    resultaat = (resultaat + ", " + str[x]);
                    Console.WriteLine("Er is gezegd: " + resultaat);
                    x++;
                }
                else
                {
                    Console.WriteLine("Begint niet met de laatste letter van " + str[x]);
                    Console.WriteLine("Er is gezegd: " + resultaat);
                    vakantie.RemoveAt(vakantie.Count - 1);
                }
            }
            else
            {
                resultaat = (resultaat + ", " + str[x]);
                Console.WriteLine("Er is gezegd: " + str[x]);
                x++;
            }
            VakantieSpullen();
        }
       
    }
}
