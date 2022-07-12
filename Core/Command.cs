using Architecture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public abstract class Command
    {
        public Core Core { get; private set; }
        public bool IsValid { get; private set; }
        public Command Execute(Core core)
        {
            Core = core;
            IsValid = Run();
            return this;
        }

        protected abstract bool Run();
    }
    public class CastleConstruct : Command
    {
        public readonly Room Room;
        public readonly Castle Castle;

        public CastleConstruct(Room room, Castle castle)
        {
            Room = room;
            Castle = castle;
        }

        protected override bool Run()
        {
            throw new NotImplementedException(); 
        }
    }
    public class RoomConstruct : Command
    {
        public readonly Room Room;
        public readonly Castle Castle;

        public RoomConstruct(Room room, Castle castle)
        {
            Room = room;
            Castle = castle;
        }

        protected override bool Run()
        {
            throw new NotImplementedException();
        }
    }
}
