using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BaseClass
    {
        public string Model { get; set; }
        public bool IsExternal { get; set; }
        public string Memory { get; set; }
        public string Price { get; set; }


        public virtual void Sound()
        {
            SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\default.wav");

            player.PlaySync();
        }
    }
}
