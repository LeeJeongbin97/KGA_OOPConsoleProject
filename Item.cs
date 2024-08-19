using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMiniGame
{
    class Item
    {
        public string Name { get; } // 아이템 이름
        public string Summary { get; } // 아이템 설명
        public int Count { get; set; } // 아이템 수량
        public string Type { get; } // 아이템 타입
        public int AttackPlus { get; } // 공격력 증가
        public int DefensePlus { get; } // 방어력 증가

        public Item(string name, string summary, int count, string type, int attackPlus = 0, int defensePlus = 0)
        {
            Name = name;
            Summary = summary;
            Count = count;
            Type = type;
            AttackPlus = attackPlus;
            DefensePlus = defensePlus;
        }
    }
}
