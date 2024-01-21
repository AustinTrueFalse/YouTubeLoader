using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeLoader
{
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Получить информацию
        public void GetInfo()
        {
            _command.GetInfo();
        }

        // Загрузить
        public void Load()
        {
            _command.Load();
        }
    }
}
