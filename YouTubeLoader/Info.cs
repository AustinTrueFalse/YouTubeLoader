using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeLoader
{
    class Info : Command
    {
        Receiver receiver;

        public Info(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Получить информацию
        public override void GetInfo()
        {
            Console.WriteLine("Команда отправлена");
            receiver.InfoOperation();
        }

        // Загрузить
        public override void Load()
        {
            Console.WriteLine("Команда отправлена");
            receiver.LoadOperation();
        }

    }
}
