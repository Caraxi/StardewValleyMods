using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLoadGame
{
    class ModConfig
    {
        public String LastFileLoaded = null;
        public Boolean LoadIntoMultiplayer = false;
        public Boolean ForgetLastFileOnTitle = true;
        public int TicksBeforeLoadSP = 5;   //ca. 0,084 seconds (assuming 60 FPS)
        public int TicksBeforeLoadMP = 300; //ca. 5 seconds (assuming 60 FPS)
    }
}
