using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMiniGame
{
    class Shop
    {
        public static void VisitShop(Player player)
        {
            Console.WriteLine("\n상점에 도착했습니다.");
            Console.WriteLine("상점 아이템 : 포션(10골드), 방어구(50골드), 검(20골드), 대검(40골드), 도끼(60골드)");
            Console.WriteLine("보유 골드 : " + player.Money); // 현재 가지고 있는 골드
            Console.WriteLine("1. 포션 구매 (10골드)");
            Console.WriteLine("2. 방어구 구매 (50골드)");
            Console.WriteLine("3. 검 구매 (20골드)");
            Console.WriteLine("4. 대검 구매 (40골드)");
            Console.WriteLine("5. 도끼 구매 (60골드)");
            Console.WriteLine("6. 돌아가기");
            Console.Write("선택: ");
            string choice = Console.ReadLine();

            if (choice == "1" && player.Money >= 10)
            {
                player.Money -= 10; // 포션 10골드 차감
                player.Inventory.AddItem(new Item("포션", "체력을 회복합니다.", 1, "Potion"));
                Console.WriteLine("포션을 구매했습니다.");
            }
            else if (choice == "2" && player.Money >= 50)
            {
                player.Money -= 50; // 방어구 50골드 차감
                player.Inventory.AddItem(new Item("방어구", "방어력을 증가시킵니다.", 1, "Armor", 0, 10));
                Console.WriteLine("방어구를 구매했습니다.");
            }
            else if (choice == "3" && player.Money >= 20)
            {
                player.Money -= 20; // 검 20골드 차감
                player.Inventory.AddItem(new Item("검", "공격력을 10 증가시킵니다.", 1, "Weapon", 10));
                Console.WriteLine("검을 구매했습니다.");
            }
            else if (choice == "4" && player.Money >= 40)
            {
                player.Money -= 40; // 대검 40골드 차감
                player.Inventory.AddItem(new Item("대검", "공격력을 20 증가시킵니다.", 1, "Weapon", 20));
                Console.WriteLine("대검을 구매했습니다.");
            }
            else if (choice == "5" && player.Money >= 60)
            {
                player.Money -= 60; // 도끼 60골드 차감
                player.Inventory.AddItem(new Item("도끼", "공격력을 30 증가시킵니다.", 1, "Weapon", 30));
                Console.WriteLine("도끼를 구매했습니다.");
            }
            else if (choice == "6")
            {
                return; // 종료
            }
            else
            {
                Console.WriteLine("자금이 부족합니다.");
            }
        }
    }
}
