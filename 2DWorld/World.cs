using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DWorld {
    class World {

        private int x, y;

        private Random rnd;

        private char character;

        private List<Items> items;

        private string containedItems;

        private char space, bitOp;

        // Constructor
        public World(int x, int y) {

            this.x = x;
            this.y = y;

            rnd = new Random();

            character = ' ';

            items = new List<Items>();

            containedItems = "";

            space = (char)0x20;
            bitOp = ' ';

            CreateWorld();
        }

        // Creates the world according to the given coordinates
        private void CreateWorld() {

            for (int i = 0; i < y; i++) {

                for (int j = 0; j < x; j++) {

                    PopulateWorld();

                    //Debugging
                    //FillString();

                    //Debugging
                    /* Console.WriteLine($"[{i},{j}] - Contains: {containedItems}" +
                        $" - Character: {character}"); */

                    //Debugging
                    containedItems = "";

                    Console.Write(character);

                    items.Clear();
                }
                Console.WriteLine();
            }
        }

        // Populates the world by calling 'NextDouble' 4 times in each cell
        // If nothing gets added into the items List, an empty space is written
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

                character = ' ';
                return;
            }

            VerifyItem();
        }

        // Verifies the Items added
        // If the 'Count' of the List equals 1,
        //  it turns the item's hex value onto its corresponding char
        // If the 'Count' is bigger than 1, 
        //  it makes a bitwise 'OR' operation of the items' hex values,
        //  turning the result into the corresponding char value
        // Finally, it adds up whatever char it has (in 'bitOp')
        //  to the 'space' char, assigning the combined char has 'character'
        private void VerifyItem() {

            if (items.Count == 1) {

                bitOp = (char)items[0];

            } else if (items.Count == 2) {

                bitOp = (char)(items[0] | items[1]);

            } else if (items.Count == 3) {

                bitOp = (char)(items[0] | items[1] | items[2]);

            } else if (items.Count == 4) {

                bitOp = (char)(items[0] | items[1] | items[2] | items[3]);
            }

            character = (Convert.ToChar(space + bitOp));
        }

        //Debugging
        private void FillString() {

            foreach (Items item in items) {

                containedItems += $"{item} ";
            }
        }
    }
}
