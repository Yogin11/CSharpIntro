// Вид 1
// void Method1()
// {
    // Console.WriteLine("Автор");
// }
// Method1();
//Вид 2
// void Method2(string msg, int count)
// {
    // Console.WriteLine(msg + count);
// }
// Method2( count: 4, msg:"Текст сообщения ");

//Вид 3
// int MEthod3()
// {
    // return DateTime.Now.Year;
// }

// int year = MEthod3();
// Console.WriteLine(year);

//Вид4
// string Method4(int count, string c)
// {
    // int i=0;
    // string result = String.Empty;
// 
    // while (i<count)
    // {
        // result +=c;
        // i++;
    // }
    // return result;
// }
// string res = Method4(10," бла  ");
// Console.WriteLine(res);

// string Method4(int count, string c)
// {
    // string result = String.Empty;
    // for (int i = 0; i <count; i++)
    // {
        // result +=c;
    // }
    // return result;
// }
// string res = Method4(10," бла  ");
// Console.WriteLine(res);

for (int i =2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

