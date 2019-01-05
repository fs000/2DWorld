using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DWorld {
    class World {

        private int x, y;

        private Random rnd;

        private string character;

        private List<Items> items;

        private string containedItems;

        private char space;

        public World(int x, int y) {

            this.x = x;
            this.y = y;

            rnd = new Random();

            character = "";

            items = new List<Items>();

            containedItems = "";

            space = (char)0x20;

            CreateWorld();
        }

        private void CreateWorld() {

            for (int i = 0; i < y; i++) {

                for (int j = 0; j < x; j++) {

                    PopulateWorld();
                    FillString();

                    //Debugging
                    Console.WriteLine($"[{i},{j}] - Contains: {containedItems} - Character: {character}");

                    containedItems = "";
                    items.Clear();
                }
                Console.WriteLine();
            }
        }

        private void PopulateWorld() {

            if (rnd.NextDouble() <= 0.1) {

                items.Add(Items.Food);
            }

            if (rnd.NextDouble() <= 0.05) {

                items.Add(Items.Guns);
            }

            if (rnd.NextDouble() <= 0.05) {

                items.Add(Items.Enemy);
            }

            if (rnd.NextDouble() <= 0.03) {

                items.Add(Items.Trap);
            }

            if (items.Count == 0) {

                Console.Write("-");
                //character = " ";
                return;
            }

            VerifyItem();
        }

        private void VerifyItem() {

            char bla = ' ';

            if (items.Count == 1) {

                bla = (char)items[0];

            } else if (items.Count == 2) {

                bla = (char)(items[0] | items[1]);

            } else if (items.Count == 3) {

                bla = (char)(items[0] | items[1] | items[2]);

            } else if (items.Count == 4) {

                bla = (char)(items[0] | items[1] | items[2] | items[3]);
            }

            Console.Write(Convert.ToChar(space + bla));
            //character = Convert.ToChar(space);
        }

        // Debugging purposes
        private void FillString() {

            foreach (Items item in items) {

                containedItems += $"{item} ";
            }
        }
    }
}
