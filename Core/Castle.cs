/// @brief Описание класса основного строения 
///
/// @copyright Copyright 2022 Amirov Karim.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    public class Castle
    {
        private readonly string _castleName;
        private readonly int _index;

        public readonly int _roomLimit;
        public readonly List<Room> rooms;
        public IEnumerable<Room> Rooms
        {
            get { return rooms; }
        }
        public enum HardLevel
        {
            easy,
            medium,
            harder, 
            hard,
            hardcore
        }

        public Castle(string castleName, int index, int roomLimit, List<Room> rooms)
        {
            _castleName = castleName;
            _index = index;
            _roomLimit = roomLimit;
            this.rooms = rooms;
        }
    }
}
