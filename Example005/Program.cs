internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя пользователя: ");
        string username = Console.ReadLine();

        if (username == "МАША")
        {
            Console.WriteLine("Отлично, Это МАША!!");

        }
        else
        {
            Console.Write("Привет, ");
            Console.WriteLine(username);
        }
    }
}