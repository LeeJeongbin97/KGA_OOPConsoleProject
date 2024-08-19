using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMiniGame
{
    class Village
    {
        public static void VisitVillage()
        {
            Console.WriteLine("\n마을에 도착했습니다.");
            Console.WriteLine("1. 마을 탐험");
            Console.WriteLine("2. 돌아가기");
            Console.Write("선택 : ");
            string choice = Console.ReadLine();

            if (choice == "1") // 마을 탐험 선택 시
            {
                Console.WriteLine("마을을 돌아다닙니다...");
            }
            else if (choice == "2") // 돌아가기 선택 시
            {
                return; // 종료
            }
            else // 아닌 경우
            {
                Console.WriteLine("잘못된 선택입니다.");
            }
        }
    }
}
