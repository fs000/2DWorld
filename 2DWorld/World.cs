using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DWorld {
    class World {

        private int x, y;

        Random rnd;

        public World(int x, int y) {

            this.x = x;
            this.y = y;

            rnd = new Random();

            CreateWorld();
        }

        private void CreateWorld() {

            for (int i = 0; i < y; i++) {

                for (int j = 0; j < x; j++) {

                    if (rnd.NextDouble() <= 0.1) {

                        Console.Write(Convert.ToChar(0x24 | 0x28));

                    } else if (rnd.NextDouble() <= 0.05) {

                        Console.Write(Convert.ToChar(0x24 | 0x28));

                    } else if (rnd.NextDouble() <= 0.05) {

                        Console.Write(Convert.ToChar(0x24 | 0x28));

                    } else if (rnd.NextDouble() <= 0.03) {

                        Console.Write(Convert.ToChar(0x24 | 0x28));

                    } else {

                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
