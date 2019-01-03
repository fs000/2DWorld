using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DWorld {
    class World {

        private int x, y;

        public World(int x, int y) {

            this.x = x;
            this.y = y;

            CreateWorld();
        }

        private void CreateWorld() {

            for (int i = 0; i < y; i++) {

                for (int j = 0; j < x; j++) {

                    Console.Write("O");
                }
                Console.WriteLine();
            }
        }
    }
}
