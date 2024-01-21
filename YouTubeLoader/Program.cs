using YoutubeExplode;
using YouTubeLoader;


class Program
{
    static void Main()
    {
        // создадим отправителя
        var sender = new Sender();

        // создадим получателя
        var receiver = new Receiver();

        // создадим команду
        var commandOne = new Info(receiver);

        // инициализация команды
        sender.SetCommand(commandOne);

        string url = "https://www.youtube.com/watch?v=uzuBET9oYiY";


        //  выполнение
        sender.GetInfo();
        sender.Load();

        Console.ReadKey();


    }
}
