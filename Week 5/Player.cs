using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return string.Format($"{Name} - {Position}");
        }
    }
}
