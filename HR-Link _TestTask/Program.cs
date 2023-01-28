Console.Clear();

int TotalApartPrice(int N, int M, int X)
{
    int totalPrc = 0;
    int stgCount = 0;

    for (int i = 0; i <= N; i++)
    {
        totalPrc += X;
        stgCount++;

        if (stgCount == M)
        {
            X += 1000;
            stgCount = 0;
        }
    }
    return totalPrc;
}

Console.WriteLine($"Total Price: {TotalApartPrice(40, 10, 10000)}$");
