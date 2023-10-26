for (int i = 10; i < 99; i++)
{
    int c1 = i / 10;
    int c2 = i % 10;
    if (c1 + c2 == 9)
        Console.WriteLine(i + " ");
}