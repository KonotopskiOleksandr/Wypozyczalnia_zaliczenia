using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenia
{
    public class Main
    {
        public Main()
        {
            Base.CreateLists();
            Base.AddTime();
        }
        public void ShowUsers()
        {
            foreach (var User in Base.Users)
            {
                Console.WriteLine($"{User.Id} |  {User.FullName} | {User.Time}");
            }
        }
        public void ShowCars()
        {
            foreach (var item in Base.Cars)
            {
                Console.WriteLine($"{item.Id} | {item.Marka} | {item.Segment} | {item.Fuel}  |  {item.Price} | {item.Status}");
            }
        }
        public void Var1()
        {
            Console.Clear();
            Console.WriteLine("LISTA KLIENTÓW:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Id | Imię i nazwisko | Data wydania prawa jazdy");
            Console.WriteLine();
            ShowUsers();
            Console.WriteLine();
            Console.WriteLine("LISTA SAMOCHODÓW:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Id | Model | Segment | Rodzaj paliwa | Cena za dobę");
            Console.WriteLine();
            ShowCars();
        }
        public static int FirstAnswer()
        {
            var FirstAnswer = Console.ReadLine();
            int.TryParse(FirstAnswer, out int result);
            if (result == 1)
            {
                return 1;
            }
            if (result == 2)
            {
                return 2;
            }
            if (result == 3)
            {
                return 3;
            }
            else
            {
                return -1;
            }
        }
        public int Is3(string A)
        {
            int.TryParse(A, out int result);
            if (result <= 3 && result > 0)
            {
                return result;
            }
            else
            {
                return -1;
            }

        }
        public int Is2(string A)
        {
            int.TryParse(A, out int result);
            if (result <= 2 && result > 0)
            {
                return result;
            }
            else
            {
                return -1;
            }

        }
        public static string GetSegment(int x)
        {
            if (x == 1)
            {
                return "mini";
            }
            if (x == 2)
            {
                return "kompakt";
            }
            if (x == 3)
            {
                return "premium";
            }
            else
            {
                return "";
            }
        }
        public static string GetFuel(int x)
        {
            if (x == 1)
            {
                return "benzyna";
            }
            if (x == 2)
            {
                return "elektryczny";
            }
            if (x == 3)
            {
                return "diesel";
            }
            else
            {
                return "";
            }
        }
        public bool GetCar(int Seg, int Fuel)
        {
            var Select = Base.Cars.Where(q => q.Segment == GetSegment(Seg) && q.Fuel == GetFuel(Fuel) && q.Status == "dostępny").LastOrDefault();
            if (Select != null)
            {
                Base.SelectedCars.Add(Select); ;
                Base.Cars[Select.Id - 1].Status = "Niedostępny";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Difference(int UserID)
        { 
            var Difference = DateTime.Now.Year - Base.Users[UserID-1].Test.Year;
            return Difference;
        }
        public static bool AnyCar()
        {
            if (Base.SelectedCars.Count > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public string GetPrice(int UserTIME, int UserID)
        {
            if (UserTIME > 7)
            {
                UserTIME--;
            }
            if (UserTIME > 29)
            {
                UserTIME = UserTIME - 2;
            }
            if (Difference(UserID) < 4)
            {
                decimal A = Base.SelectedCars.Last().PerHR * UserTIME;
                A = A / 100 * 120;
                return $"OPŁATA {A} PLN ";
            }
            else
            {
                decimal A = Base.SelectedCars.Last().PerHR * UserTIME;
                return $"OPŁATA {A} PLN ";
            }
        }
    }
}
