/// @brief Описание класса юнита 
///
/// @copyright Copyright 2022 Amirov Karim.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Unit
    {
        private readonly bool isEnemy;
        private readonly string name;

        public int _damage;
        public int _hitPoints;
        public int _expirience;



    }

    public class Player : Unit
    {

    }

    public class Enemy : Unit
    {

    }
}
