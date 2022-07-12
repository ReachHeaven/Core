/// @brief Описание класса комнат 
///
/// @copyright Copyright 2022 Amirov Karim.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    public class Room
    {
        private readonly int _height;
        private readonly int _weight;
        private readonly int _capacity;
        public enum Type
        {
            BattleRoom,
            TreasureRoom
        }
        public int _index;
        public Type _type;

        public Room(int height, int weight, int capacity, int index, Type type)
        {
            if(height > 300 || weight > 300)
            {
                Console.WriteLine("Height or weight of room is out of range");
                return;
            }
            _height = height;
            _weight = weight;

            _type = type;
            if(type != 0)
            {
                _capacity = 0;
            }
            else
            {
                _capacity = capacity;

            }
            _index = index;
            
        }
    }
}
