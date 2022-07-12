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

        public readonly int _roomLimit = 10;
        public readonly List<Room> rooms;
        public IEnumerable<Room> Rooms
        {
            get { return rooms; }
        }
        /// <summary>
        /// Уровень сложности замка
        /// </summary>
        public enum HardLevel
        {
            easy,
            medium,
            harder, 
            hard,
            hardcore
        }
        /// <summary>
        /// Создает комнаты в замке
        /// </summary>
        public void CreateDefaultRooms()
        {
            for (var i = 0; i < _roomLimit; i++)
            {
                rooms.Add(new Room(300, 300, 10, i, Room.Type.BattleRoom));
            }

            for (var i = 0; i < _roomLimit; i += 2)
            {
                rooms.Add(new Room(300, 300, 10, i, Room.Type.TreasureRoom));
            }
        }
        /// <summary>
        /// Возвращает комнату по индексу
        /// </summary>
        /// <param name="index">Индекс комнаты</param>
        /// <returns></returns>
        public Room GetRoom(int index)
        {
            return rooms[index];
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
