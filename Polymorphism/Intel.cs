using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Intel : BaseClass
    {
        public override void Sound()
        {
            SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\intel.wav");
            player.PlaySync();
        }
    }
}