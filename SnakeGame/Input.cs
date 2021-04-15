using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // The hashtable class is in the collections
using System.Windows.Forms; // The keys class is in the Forms 

namespace SnakeGame
{
    class Input
    {
        // creating a new instance of Hashtable class this class is used to optimize the keys inserted in it
        private static Hashtable keyTable = new(); 

        public static bool KeyPress(Keys key)
        {
            // this function will return a key back to the class
            if (keyTable[key] == null)
            {
                // if the hashtable is empty then we return false
                return false;
            }
            // if the hastable is not empty then we return true
            return (bool)keyTable[key];
        }

        // this function will change state of the keys and the player with it this function has two arguments Key and state
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

    }
}