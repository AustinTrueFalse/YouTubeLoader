using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeLoader
{
    abstract class Command
    {
        public abstract void GetInfo();
        public abstract void Load();
    }
}
