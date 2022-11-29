
using System.Collections.Generic;
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





while (true)
{
    Console.Clear();
    message.FirstMessage();
    int Answer1 = main.FirstAnswer();
    Console.WriteLine();

    if (Answer1 == 1)
    {
        main.Var1();
        message.OpenMenu();
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
                break;
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
                z++;
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
            }
            if (g == 1)
            {
                message.LastMessage(main.GetById(UserId),
                                    main.GetCar(UserSeg, UserFuel),
                                    main.GetFuel(UserFuel),
                                    main.GetPrice(UserSeg, UserFuel, UserTime),
                                    main.GetSegment(UserSeg), UserTime);
                message.OpenMenu();
            }
        }
    }
    if (Answer1 == 3)
    {
        Console.Clear();
        break;
    }
}
