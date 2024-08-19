using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMiniGame
{
    class Game
    {
        private Player player; // 플레이어
        private Random random; // 임의의 수

        public Game()
        {
            player = new Player("모험가", 100, 20, 50); // 플레이어 초기화 체력 100, 공격력20, 초기 자본 50 골드
            random = new Random(); // 임의의 수 초기화
        }

        public void Start()
        {
            Console.WriteLine("게임 시작");

            bool isRunning = true; // 게임이 실행중인지
            while (isRunning)
            {
                Console.Clear(); // 화면 지우개
                AllTime(); // 항상 출력될 캐릭터 스탯(?)

                // 게임 메뉴
                Console.WriteLine("\n1. 마을");
                Console.WriteLine("2. 상점");
                Console.WriteLine("3. 초원");
                Console.WriteLine("4. 인벤토리");
                Console.WriteLine("5. 종료");
                Console.Write("선택 : ");
                string input = Console.ReadLine(); // 플레이어 메뉴 선택 입력

                Console.WriteLine($"선택한 메뉴: {input}");

                // 입력에 따른 게임 메뉴 동작
                switch (input)
                {
                    case "1":
                        Village.VisitVillage();
                        break;
                    case "2":
                        Shop.VisitShop(player);
                        break;
                    case "3":
                        VisitMeadow();
                        break;
                    case "4":
                        Inventory.ShowInventory(player);
                        break;
                    case "5":
                        isRunning = false;
                        Console.WriteLine("게임 종료");
                        break;
                    default:
                        Console.WriteLine("올바른 선택지를 골라주세요.");
                        break;
                }

                Console.ReadLine(); // 창 유지
            }
        }

        private void AllTime()
        {
            // 캐릭터 스탯 상태
            Console.WriteLine("===== 게임 상태 =====");
            Console.WriteLine($"체력 : {player.Health} / 100");
            Console.WriteLine($"보유 머니 : {player.Money} 골드");
            Console.WriteLine($"공격력 : {player.Attack}");
            Console.WriteLine($"방어력 : {player.Defense}");
            Console.WriteLine("=====================");
        }

        private void VisitMeadow()
        {
            Console.WriteLine("\n초원에 진입했습니다.");
            Console.WriteLine("1. 사냥");
            Console.WriteLine("2. 바다로 진입하기"); // 초원을 지나 바다로 진입 가능
            Console.WriteLine("3. 돌아가기");
            Console.Write("선택: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int result = random.Next(0, 2); // 랜덤 생성
                if (result == 1) // 사냥 성공 시
                {
                    int loot = random.Next(5, 20); // 5 ~ 20 사이의 랜덤 골드
                    player.Money += loot; // 획득
                    Console.WriteLine($"몬스터 사냥에 성공했습니다. 아이템을 팔아 {loot} 골드를 얻었습니다.");
                }
                else // 사냥 실패 시
                {
                    Console.WriteLine("몬스터 사냥에 실패했습니다.");
                }
            }
            else if (choice == "2") // 바다 진입 선택 시
            {
                VisitSea(); // sea 메소드 호출
            }
            else if (choice == "3") // 돌아가기 선택 시
            {
                return; // 종료
            }
            else // 잘못 선택 시
            {
                Console.WriteLine("올바른 선택지를 골라주세요.");
            }

            Console.WriteLine("초원 탐험이 종료되었습니다.");
            Console.ReadLine(); // 창 유지
        }

        private void VisitSea() // 위와 동일
        {
            Console.WriteLine("\n바다에 도달했습니다.");
            Console.WriteLine("1. 낚시하기");
            Console.WriteLine("2. 돌아가기");
            Console.Write("선택: ");
            string choice = Console.ReadLine();

            Console.WriteLine($"선택한 옵션: {choice}");

            if (choice == "1")
            {
                Console.WriteLine("낚시를 시도합니다...");
                int result = random.Next(0, 2);
                Console.WriteLine($"낚시 결과: {result}");

                if (result == 1)
                {
                    int fishValue = random.Next(10, 30);
                    player.Money += fishValue;
                    Console.WriteLine($"낚시에 성공했습니다 아이템을 팔아 {fishValue} 골드를 얻었습니다.");
                }
                else
                {
                    Console.WriteLine("낚시에 실패했슈");
                }
            }
            else if (choice == "2")
            {
                return;
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다.");
            }

            Console.WriteLine("낚시가 종료되었습니다.");
            Console.ReadLine();
        }
    }
}
