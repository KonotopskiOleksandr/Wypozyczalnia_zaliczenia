
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Zaliczenia;

var message = new Message();
var main = new Main();

int UserId;
int UserSeg;
int UserFuel;
int UserTime;
int Answer1;




while (true)
{
    Console.Clear();
    message.FirstMessage();
    Answer1 = Main.FirstAnswer();
    Console.WriteLine();

    if (Answer1 == 1)
    {
        main.Var1();
        message.OpenMenu();
    }
    if (Answer1 == 2)
    {
        while (true)
        {
            message.PodajId();
            int Odp1 = main.Is3(Console.ReadLine());

            if (Odp1 == -1)
            {
                message.WrongInt();
            }

            if (Odp1 > 0 && Odp1 < 6)
            {
                UserId = Odp1;
                break;
            }
        }
        
        while (true)
        {
            if (Main.Difference(UserId) > 4)
            {
                message.TakeSegment(UserId);
                int Odp2 = main.Is3(Console.ReadLine());

                if (Odp2 == -1)
                {
                    message.WrongSeg();
                }

                if (Odp2 < 4 && Odp2 > 0)
                {
                    UserSeg = Odp2;
                    break;
                }
            }
            if (Main.Difference(UserId) < 4)
            {
                message.TakeSegment(UserId);
                int Odp2 = main.Is2(Console.ReadLine());

                if (Odp2 == -1)
                {
                    message.WrongSeg();
                }
                if (Odp2 < 3 && Odp2 > 0)
                {
                    UserSeg = Odp2;
                    break;
                }
            }
        }
        while (true)
        {
            message.PodajFuel();
            int Odp3 = main.Is3(Console.ReadLine());

            if (Odp3 == -1)
            {
                message.WrongFuel();
            }

            if (Odp3 < 4 && Odp3 > 0)
            {
                UserFuel = Odp3;
                break;
            }
        }
        while (true)
        {

        int Odp4 = message.PodajCzas();
        if (Odp4 > 0)
        {
            Console.Clear();
            UserTime = Odp4;
            break;
        }
            if (Odp4 == -1)
        { 
            message.WrongTime();
        }
        }
        if (main.GetCar(UserSeg, UserFuel))
        {
            message.LastMessage(main.GetPrice(UserTime, UserId), UserTime, UserId);
            message.OpenMenu();
        }
        else
        {
            message.DontHaveAnyCar();
        }
    }
    if (Answer1 == 3)
    {
        Console.Clear();
        break;
    }
}
