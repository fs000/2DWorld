using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DWorld {
    class Input {

        public Input() { }

        public int GetX() {

            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            return x;
        }

        public int GetY() {

            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            return y;
        }
    }
}
