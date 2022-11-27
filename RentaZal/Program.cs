using RentaZal;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
var rand = new Random();
var CurrectSegment = "mini";
var CurrectFuel = "benzyna";
var message = new Message();

List<Clients> Users = new List<Clients>();
Users.Add(new Clients(1, "Jan", " Nowak", "04.03.2021 r."));
Users.Add(new Clients(2, "Agnieszka", " Kowalska", "15.01.1999 r."));
Users.Add(new Clients(3, "Robert", " Lewandowski", "18.12.2010 r."));
Users.Add(new Clients(4, "Zofia", " Plucińska", "29.04.2020 r."));
Users.Add(new Clients(5, "Grzegorz", " Braun", "12.07.2015 r."));

List<AllCars> Cars1 = new List<AllCars>();
Cars1.Add(new AllCars(1, "Škoda Citigo", "mini", "benzyna", 70, "dostępny"));
Cars1.Add(new AllCars(2, "Toyota Aygo", "mini", "benzyna", 90, "dostępny"));
Cars1.Add(new AllCars(3, "Fiat 500 ", "mini", "elektryczny", 110, " dostępny"));
Cars1.Add(new AllCars(4, "Ford Focus", "kompakt", "diesel", 160, "dostępny"));
Cars1.Add(new AllCars(5, "Kia Ceed", "kompakt", "benzyna", 150, "dostępny"));
Cars1.Add(new AllCars(6, "Volkswagen Golf", "kompakt", "benzyna",160, "dostępny"));
Cars1.Add(new AllCars(7, "Hyundai Kona", "kompakt", "elektryczny",180, "dostępny"));
Cars1.Add(new AllCars(8, "Audi A6 Allroad", "premium", "diesel", 290, "dostępny"));
Cars1.Add(new AllCars(9, "Mercedes E270 AMG ", "premium", "benzyna", 320, "dostępny"));
Cars1.Add(new AllCars(10, "Tesla Model S", "premium", "elektryczny", 350, "dostępny"));







message.FirstMessage();
var FirstAnswer = Console.ReadLine();

int.TryParse(FirstAnswer, out int result);

bool One = (result == 1);
bool Two = (result == 2);  
bool Three = (result == 3);



if (Two)
{
    message.PodajId();
    var AnswerID = Convert.ToInt32(Console.ReadLine());

    message.PodajSegment();
    var AnswerSegmet = Convert.ToInt32(Console.ReadLine());
    bool m = AnswerSegmet == 1;
    bool k = AnswerSegmet == 2;
    bool p = AnswerSegmet == 3;
    if (m)
    {
        CurrectSegment = "mini";
    }
    if (k)
    {
        CurrectSegment = "kompakt";
    }
    if (p)
    {
        CurrectSegment = "premium";
    }

    message.PodajFuel();
    var AnswerFuel = Convert.ToInt32(Console.ReadLine());
    bool benz = AnswerFuel == 1;
    bool elec = AnswerFuel == 2;
    bool dis = AnswerFuel == 3;
    if (benz)
    {
        CurrectFuel = "benzyna";
    }
    if (elec)
    {
        CurrectFuel = "elektryczny";
    }
    if (dis)
    {
        CurrectFuel = "diesel";
    }


    message.PodajCzas();
    var AnswerTime = Convert.ToInt32(Console.ReadLine());
    var CurretTime = DateTime.Now.ToString("MM.dd.yyyy");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("UMOWA WYNAJMU POJAZDU");
    Console.WriteLine("DATA ZAWARCIA: " + CurretTime);
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("WYNAJMUJĄCY:" + Users[AnswerID].FullName);
    var miniK = Cars1.Where(q => q.Segment == CurrectSegment).ToList();
    var AfterFuel = miniK.Where(q => q.Fuel == CurrectFuel).ToList();
    var CurretCar = AfterFuel[rand.Next(AfterFuel.Count)];
    Console.WriteLine("RODZAJ POJAZDU: " + CurretCar.Marka);
    Console.WriteLine("RODZAJ PALIWA: " + CurretCar.Fuel);
    Console.WriteLine("SEGMENT: " + CurretCar.Segment);
    var ZworotTime = DateTime.Now.AddDays(AnswerTime).ToString("MM.dd.yyyy");
    Console.WriteLine("DATA ZWROTU POJAZDU: " + ZworotTime );
    double RentPrice = CurretCar.PerHR * AnswerTime;
    Console.WriteLine("OPŁATA: " + RentPrice + " PLN");




}
if (One)
{
    Console.WriteLine("LISTA KLIENTÓW:");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Id | Imię i nazwisko | Data wydania prawa jazdy");
    Console.WriteLine();
    {
        for (int i = 0; i < Users.Count; i++)
        {
            var B = Users[i].FirstName + Users[i].LastName;
            Console.WriteLine((Users[i].Id) + " | " + B + "  | " + Users[i].Time);
        }
    }
    Console.WriteLine();
    Console.WriteLine("LISTA SAMOCHODÓW:");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Id | Model | Segment | Rodzaj paliwa | Cena za dobę");
    Console.WriteLine();

    for (int i = 0; i < Cars1.Count; i++)
    {
        Console.WriteLine(Cars1[i].Id + " | " + Cars1[i].Marka + " | " + Cars1[1].Segment + " | " + Cars1[i].Fuel + " | " + Cars1[i].Price);
    }
}

