using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenia
{
    public class Main
    {
        public void ShowUsers()
        {
            List<AllUsers> Users = new List<AllUsers>();
            Users.Add(new AllUsers(1, "Jan", " Nowak", "04.03.2021 r."));
            Users.Add(new AllUsers(2, "Agnieszka", " Kowalska", "15.01.1999 r."));
            Users.Add(new AllUsers(3, "Robert", " Lewandowski", "18.12.2010 r."));
            Users.Add(new AllUsers(4, "Zofia", " Plucińska", "29.04.2020 r."));
            Users.Add(new AllUsers(5, "Grzegorz", " Braun", "12.07.2015 r."));
            for (int i = 0; i < Users.Count; i++)
            {
                var B = Users[i].FirstName + Users[i].LastName;
                Console.WriteLine((Users[i].Id) + " | " + B + "  | " + Users[i].Time);
            }
        }
        public void ShowCars()
        {
            List<AllCars> Cars1 = new List<AllCars>();
            Cars1.Add(new AllCars(1, "Škoda Citigo", "mini", "benzyna", 70, "dostępny"));
            Cars1.Add(new AllCars(2, "Toyota Aygo", "mini", "benzyna", 90, "dostępny"));
            Cars1.Add(new AllCars(3, "Fiat 500 ", "mini", "elektryczny", 110, " dostępny"));
            Cars1.Add(new AllCars(4, "Ford Focus", "kompakt", "diesel", 160, "dostępny"));
            Cars1.Add(new AllCars(5, "Kia Ceed", "kompakt", "benzyna", 150, "dostępny"));
            Cars1.Add(new AllCars(6, "Volkswagen Golf", "kompakt", "benzyna", 160, "dostępny"));
            Cars1.Add(new AllCars(7, "Hyundai Kona", "kompakt", "elektryczny", 180, "dostępny"));
            Cars1.Add(new AllCars(8, "Audi A6 Allroad", "premium", "diesel", 290, "dostępny"));
            Cars1.Add(new AllCars(9, "Mercedes E270 AMG ", "premium", "benzyna", 320, "dostępny"));
            Cars1.Add(new AllCars(10, "Tesla Model S", "premium", "elektryczny", 350, "dostępny"));
            foreach (var item in Cars1)
            {
                Console.WriteLine($"{item.Id} | {item.Marka} | {item.Segment} | {item.Fuel}  |  {item.Price} | {item.Status}");
            }
            {

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
        public int FirstAnswer()
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
        public int IsInt(string A)
        {
            int.TryParse(A, out int result);
            if (result <= 5 && result > 0)
            {
                return result;
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
        public string GetSegment(int x)
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
        public string GetFuel(int x)
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
        public string GetCar(int Seg, int Fuel)
        {
            List<AllCars> Cars = new List<AllCars>();
            Cars.Add(new AllCars(1, "Škoda Citigo", "mini", "benzyna", 70, "dostępny"));
            Cars.Add(new AllCars(2, "Toyota Aygo", "mini", "benzyna", 90, "dostępny"));
            Cars.Add(new AllCars(3, "Fiat 500 ", "mini", "elektryczny", 110, " dostępny"));
            Cars.Add(new AllCars(4, "Ford Focus", "kompakt", "diesel", 160, "dostępny"));
            Cars.Add(new AllCars(5, "Kia Ceed", "kompakt", "benzyna", 150, "dostępny"));
            Cars.Add(new AllCars(6, "Volkswagen Golf", "kompakt", "benzyna", 160, "dostępny"));
            Cars.Add(new AllCars(7, "Hyundai Kona", "kompakt", "elektryczny", 180, "dostępny"));
            Cars.Add(new AllCars(8, "Audi A6 Allroad", "premium", "diesel", 290, "dostępny"));
            Cars.Add(new AllCars(9, "Mercedes E270 AMG ", "premium", "benzyna", 320, "dostępny"));
            Cars.Add(new AllCars(10, "Tesla Model S", "premium", "elektryczny", 350, "dostępny"));
            List<AllCars> Select = Cars.Where(q => q.Segment == GetSegment(Seg)).ToList();
            List<AllCars> Select2 = Select.Where(q => q.Fuel == GetFuel(Fuel)).ToList();
            return Select2[0].Marka;
        }
        public string GetPrice(int Seg, int Fuel, int Time)
        {
            List<AllCars> Cars = new List<AllCars>();
            Cars.Add(new AllCars(1, "Škoda Citigo", "mini", "benzyna", 70, "dostępny"));
            Cars.Add(new AllCars(2, "Toyota Aygo", "mini", "benzyna", 90, "dostępny"));
            Cars.Add(new AllCars(3, "Fiat 500 ", "mini", "elektryczny", 110, " dostępny"));
            Cars.Add(new AllCars(4, "Ford Focus", "kompakt", "diesel", 160, "dostępny"));
            Cars.Add(new AllCars(5, "Kia Ceed", "kompakt", "benzyna", 150, "dostępny"));
            Cars.Add(new AllCars(6, "Volkswagen Golf", "kompakt", "benzyna", 160, "dostępny"));
            Cars.Add(new AllCars(7, "Hyundai Kona", "kompakt", "elektryczny", 180, "dostępny"));
            Cars.Add(new AllCars(8, "Audi A6 Allroad", "premium", "diesel", 290, "dostępny"));
            Cars.Add(new AllCars(9, "Mercedes E270 AMG ", "premium", "benzyna", 320, "dostępny"));
            Cars.Add(new AllCars(10, "Tesla Model S", "premium", "elektryczny", 350, "dostępny"));
            List<AllCars> Select = Cars.Where(q => q.Segment == GetSegment(Seg)).ToList();
            List<AllCars> Select2 = Select.Where(q => q.Fuel == GetFuel(Fuel)).ToList();
            int A = Select2[0].PerHR * Time;
            return "OPŁATA:" + A + "PLN";
        }
        public string GetById(int b)
        {
            List<AllUsers> Users = new List<AllUsers>();
            Users.Add(new AllUsers(1, "Jan", " Nowak", "04.03.2021 r."));
            Users.Add(new AllUsers(2, "Agnieszka", " Kowalska", "15.01.1999 r."));
            Users.Add(new AllUsers(3, "Robert", " Lewandowski", "18.12.2010 r."));
            Users.Add(new AllUsers(4, "Zofia", " Plucińska", "29.04.2020 r."));
            Users.Add(new AllUsers(5, "Grzegorz", " Braun", "12.07.2015 r."));
            List<AllUsers> Select = Users.Where(q => q.Id == b).ToList();
            return Select[0].FullName;

        }
    }
}
