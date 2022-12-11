using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenia
{
    public static class Base
    {
        public static List<AllCars> Cars = new List<AllCars>();
        public static List<AllUsers> Users = new List<AllUsers>();
        public static List<AllCars> SelectedCars = new List<AllCars>();

        public static void CreateLists()
        {
            Users.Add(new AllUsers(1, "Jan", " Nowak", "04.03.2021 r."));
            Users.Add(new AllUsers(2, "Agnieszka", " Kowalska", "15.01.1999 r."));
            Users.Add(new AllUsers(3, "Robert", " Lewandowski", "18.12.2010 r."));
            Users.Add(new AllUsers(4, "Zofia", " Plucińska", "29.04.2020 r."));
            Users.Add(new AllUsers(5, "Grzegorz", " Braun", "12.07.2015 r."));
            Cars.Add(new AllCars(1, "Škoda Citigo", "mini", "benzyna", 70.00m, "dostępny"));
            Cars.Add(new AllCars(2, "Toyota Aygo", "mini", "benzyna", 90.00m, "dostępny"));
            Cars.Add(new AllCars(3, "Fiat 500", "mini", "elektryczny", 110.00m, "dostępny"));
            Cars.Add(new AllCars(4, "Ford Focus", "kompakt", "diesel", 160.00m, "dostępny"));
            Cars.Add(new AllCars(5, "Kia Ceed", "kompakt", "benzyna", 150.00m, "dostępny"));
            Cars.Add(new AllCars(6, "Volkswagen Golf", "kompakt", "benzyna", 160.00m, "dostępny"));
            Cars.Add(new AllCars(7, "Hyundai Kona", "kompakt", "elektryczny", 180.00m, "dostępny"));
            Cars.Add(new AllCars(8, "Audi A6 Allroad", "premium", "diesel", 290.00m, "dostępny"));
            Cars.Add(new AllCars(9, "Mercedes E270 AMG ", "premium", "benzyna", 320.00m, "dostępny"));
            Cars.Add(new AllCars(10, "Tesla Model S", "premium", "elektryczny", 350.00m, "dostępny"));
        }
        public static void AddTime()
        {
            Users[0].Test = new DateTime(2021, 3 , 04);
            Users[1].Test = new DateTime(1999, 1, 15);
            Users[2].Test = new DateTime(2010, 12, 18);
            Users[3].Test = new DateTime(2020, 4, 29);
            Users[4].Test = new DateTime(2015, 7, 12);
        }
    }
}
