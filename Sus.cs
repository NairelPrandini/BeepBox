class Program
{
    static void Main()
    {
        Console.Beep(523, 200);
        Console.Beep(622, 200);
        Console.Beep(698, 200);
        Console.Beep(740, 200);

        Console.Beep(698, 200);
        Console.Beep(622, 200);
        Console.Beep(523, 200);
        System.Threading.Thread.Sleep(1400);
        Console.Beep(466, 100);
        Console.Beep(587, 100);
        Console.Beep(523, 100);
        System.Threading.Thread.Sleep(1400);

        Console.Beep(523, 200);
        Console.Beep(622, 200);
        Console.Beep(698, 200);
        Console.Beep(740, 200);

        Console.Beep(698, 200);
        Console.Beep(622, 200);
        Console.Beep(740, 200);

        System.Threading.Thread.Sleep(1000);

        Console.Beep(740, 100);
        Console.Beep(698, 100);
        Console.Beep(622, 100);
        Console.Beep(740, 100);
        Console.Beep(698, 100);
        Console.Beep(622, 100);
        Console.Beep(523, 100);

    }
}
