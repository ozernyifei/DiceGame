

    Random rnd = new Random();

    Console.WriteLine("---   Start Game   ---");
    Console.Write("\nВведите число (2..12) : ");

    int predict = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вы ввели: " + predict + "\n");

    int summa = sum(RollTheDice(), RollTheDice());
    int score = summa - Math.Abs(summa - predict) * 2; //подсчет  очков

    Console.WriteLine("\nНа кубиках выпало {0} точек", summa);
    Console.WriteLine("\nРезультат {0}-abs({0}-{1})*2: {2} очков", summa, predict, score);

    if (score > 0)
    {
        Console.WriteLine("\nПобедил игрок.");
    }
    else
    {
        Console.WriteLine("\nПобедил ИИ.");
    }

    int RollTheDice()
    {
        int number = rnd.Next(1, 7);
        Printdice(number);
        return number;
    }

    int sum(int n1, int n2)
    {
        return n1 + n2;
    }

    void Printdice(int number)
    {
        switch (number)
        {
            case 1:
                Console.WriteLine("---------");
                Console.WriteLine("|       |");
                Console.WriteLine("|   #   |");
                Console.WriteLine("|       |");
                Console.WriteLine("---------");
                break;
            case 2:
                Console.WriteLine("---------");
                Console.WriteLine("| #     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     # |");
                Console.WriteLine("---------");
                break;
            case 3:
                Console.WriteLine("---------");
                Console.WriteLine("| #     |");
                Console.WriteLine("|   #   |");
                Console.WriteLine("|     # |");
                Console.WriteLine("---------");
                break;
            case 4:
                Console.WriteLine("---------");
                Console.WriteLine("| #   # |");
                Console.WriteLine("|       |");
                Console.WriteLine("| #   # |");
                Console.WriteLine("---------");
                break;
            case 5:
                Console.WriteLine("---------");
                Console.WriteLine("| #   # |");
                Console.WriteLine("|   #   |");
                Console.WriteLine("| #   # |");
                Console.WriteLine("---------");
                break;
            case 6:
                Console.WriteLine("---------");
                Console.WriteLine("| # # # |");
                Console.WriteLine("|       |");
                Console.WriteLine("| # # # |");
                Console.WriteLine("---------");
                break;
        }
    }
    Console.ReadKey();
