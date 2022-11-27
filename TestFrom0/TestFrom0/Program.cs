
using System.Security.Cryptography.X509Certificates;
using Zaliczenia;

var message = new Message();
var main = new Main();



int z = 0;
int g = 0;
int UserId = 0;
int UserSeg = 0;
int UserFuel = 0;
int UserTime = 0;
var CurretTime = DateTime.Now.ToString("MM.dd.yyyy");



message.FirstMessage();
int Answer1 = main.FirstAnswer();


if (Answer1 == 1)
{
    main.Var1();
}
if (Answer1 == 2)
{
    while (z == 0)
    {
        message.PodajId();
        int Odp1 = main.IsInt(Console.ReadLine());

        if (Odp1 == -1)
        {
            message.WrongInt();
        }
        if (Odp1 > 0 && Odp1 < 6)
        {
            UserId = UserId + Odp1;
            z++;
        }
    }
    while (z == 1)
    {
        message.PodajSegment();
        int Odp2 = main.Is3(Console.ReadLine());
        if (Odp2 == -1)
        {
            message.WrongSeg();
        }
        if (Odp2 < 4 && Odp2 > 0)
        {
            UserSeg = UserSeg + Odp2;
            z++;
        }
    }
    while (z == 2)
    {
        message.PodajFuel();
        int Odp3 = main.Is3(Console.ReadLine());
        if (Odp3 == -1)
        {
            message.WrongFuel();
        }
        if (Odp3 < 4 && Odp3 > 0)
        {
            UserFuel = UserFuel + Odp3;
            break;
        }
    }


    while (g == 0)
    {
        int Odp4 = message.PodajCzas();

        if (Odp4 > 0)
        {
            Console.Clear();
            UserTime = UserTime + Odp4;
            g++;
        }
        if (Odp4 == -1)
        {
            message.WrongTime();
            g++;
        }
    }
}
if (Answer1 == 3)
{
    Console.Clear();
    Environment.Exit(0);
}


if (g == 1)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("UMOWA WYNAJMU POJAZDU");
    Console.WriteLine("DATA ZAWARCIA: " + CurretTime);
    Console.WriteLine("-----------------------------------");
    Console.Write("WYNAJMUJĄCY: ");
    main.GetById(UserId);
    Console.WriteLine("RODZAJ POJAZDU: " + main.GetCar(UserSeg, UserFuel));
    Console.WriteLine("RODZAJ PALIWA: " + main.GetFuel(UserFuel));
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("SEGMENT: " + main.GetSegment(UserSeg));
    var ZworotTime = DateTime.Now.AddDays(UserTime).ToString("MM.dd.yyyy");
    Console.WriteLine("DATA ZWROTU POJAZDU: " + ZworotTime);
    main.GetPrice(UserSeg, UserFuel, UserTime);
}


