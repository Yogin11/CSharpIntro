int V1 = 1, V2 = 2, Vs = 5;
int distance = 10000, count = 0, friend = 2;
int time;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (V1 + Vs);
        friend = 2;
    }
    else
    {
        time = distance / (V2 + Vs);
        friend = 1;
    }
    distance = distance - time * (V1 + V2);
    count += 1;
}
Console.Clear();
Console.WriteLine("Собака пробежит " + count + " раз");
