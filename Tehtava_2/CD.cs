using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_2
{
    class CD
    {
        public string Artist { get; set; }
        public string Price { get; set; }
        public string SongList { get; set; }

        public override string ToString()
        {
            return "- " + Artist + "\n- " + Price + "\n- " + SongList;
        }
    }
}
