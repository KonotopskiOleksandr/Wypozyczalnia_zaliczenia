using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaZal
{
    internal class Message
    {
        public void FirstMessage()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA KLIENTÓW I SAMOCHODÓW");
            Console.WriteLine("2 => WYPOŻYCZENIE SAMOCHODU");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
        }
        public void PodajId()
        {
            Console.Clear();
            Console.WriteLine("PROSZĘ PODAĆ ID KLIENTA, KTÓRY WYPOŻYCZA SAMOCHÓD:");
        }
        public void PodajSegment()
        {
            Console.Clear();
            Console.WriteLine("PODAJ SEGMENT SAMOCHODU:");
            Console.WriteLine("1. mini");
            Console.WriteLine("2. kompakt");
            Console.WriteLine("3. premium");
        }
        public void PodajFuel()
        {
            Console.Clear();
            Console.WriteLine("PODAJ PREFEROWANY RODZAJ PALIWA:");
            Console.WriteLine("1. benzyna");
            Console.WriteLine("2. elektryczny");
            Console.WriteLine("3. diesel");
        }
        public void PodajCzas()
        {
            Console.Clear();
            Console.WriteLine("PODAJ ILOŚĆ DNI WYNAJMU POJAZDU:");
        }
    }
    
}
