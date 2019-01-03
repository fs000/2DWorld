using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DWorld {
    class Program {
        static void Main(string[] args) {

            Input myInput = new Input();

            int x = myInput.GetX();
            Console.Clear();
            int y = myInput.GetY();

            Console.Clear();
            World myWorld = new World(x, y);
        }

        
    }
}
