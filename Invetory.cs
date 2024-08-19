using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMiniGame
{
    class Inventory
    {
        private List<Item> items; // 아이템 리스트

        public Inventory()
        {
            items = new List<Item>(); // 리스트 초기화
        }

        public void AddItem(Item item)
        {
            items.Add(item); // 아이템 리스트 추가
            Console.WriteLine($"{item.Name}을(를) 인벤토리에 추가했습니다.");
        }

        public void ShowItems()
        {
            if (items.Count == 0) // 아이템이 없을 때
            {
                Console.WriteLine("인벤토리에 아이템이 없습니다.");
                return; // 종료
            }

            foreach (Item item in items) // 리스트 아이템 반복
            {
                Console.WriteLine($"아이템: {item.Name}, 설명: {item.Summary}, 수량: {item.Count}, 유형: {item.Type}, 공격력 증가: {item.AttackPlus}, 방어력 증가: {item.DefensePlus}");
            }
        }

        public void UseItem(string itemName, Player player)
        {
            Item findItem = null; // 아이템을 찾기 위한 변수

            if (findItem != null) // 아이템이 있을 경우
            {
                if (findItem.Type == "Potion") // 포션알 때
                {
                    // 포션 사용 시 체력 회복
                    player.Health = Math.Min(player.Health + 30, 100); // 최대 체력은 100
                    Console.WriteLine($"체력이 30 회복되었습니다. 현재 체력: {player.Health}");
                }
                else if (findItem.Type == "Weapon") // 무기일 때
                {
                    // 무기 사용 시 공격력 증가
                    player.Attack += findItem.AttackPlus;
                    Console.WriteLine($"{findItem.Name}을(를) 사용하여 공격력이 {findItem.AttackPlus} 증가했습니다. 현재 공격력: {player.Attack}");
                }
                else if (findItem.Type == "Armor") // 방어구 일 때
                {
                    // 방어구 사용 시 방어력 증가
                    player.Defense += findItem.DefensePlus;
                    Console.WriteLine($"{findItem.Name}을(를) 사용하여 방어력이 {findItem.DefensePlus} 증가했습니다. 현재 방어력: {player.Defense}");
                }

                findItem.Count--; // 아이템 소모
                if (findItem.Count <= 0) // 아이템이 0 이하일 때
                {
                    items.Remove(findItem); // 아이템 제거
                }
            }
            else // 아이템이 없을 때
            {
                Console.WriteLine("해당 아이템이 없습니다.");
            }
        }

        public static void ShowInventory(Player player)
        {
            Console.WriteLine("\n인벤토리:");
            player.Inventory.ShowItems();
            Console.WriteLine("1. 아이템 사용");
            Console.WriteLine("2. 돌아가기");
            Console.Write("선택: ");
            string choice = Console.ReadLine();

            if (choice == "1") // 아이템 사용시
            {
                Console.Write("사용할 아이템 이름을 입력하세요: "); // 아이템 이름 입력을 출력
                string itemName = Console.ReadLine(); // 아이텝 이름 입력
                player.Inventory.UseItem(itemName, player); // 입력된 아이템 사용
            }
            else if (choice == "2") // 돌아가기 선택시
            {
                return; // 종료
            }
            else // 잘못 선택 시
            {
                Console.WriteLine("올바른 선택지를 골라주세요.");
            }
        }
    }
}
