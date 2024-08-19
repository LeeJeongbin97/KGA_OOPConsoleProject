using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMiniGame
{
    class Player
    {
        public string Name { get; } // 플레이어 이름
        public int Health { get; set; } // 플레이어 체력
        public int Attack { get; set; } // 플레이어 공격력
        public int Money { get; set; } // 플레이어 골드
        public int Defense { get; set; } // 플레이어 방어력
        public Inventory Inventory { get; } // 플레이어 인벤토뤼

        public Player(string name, int health, int attack, int money)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Money = money;
            Defense = 0; // 기본 방어력 0으로 설정
            Inventory = new Inventory();
        }
    }
}
