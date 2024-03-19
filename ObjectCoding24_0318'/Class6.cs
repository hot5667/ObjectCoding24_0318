//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectCoding24_0318_
//{
//    using System;
//    using System.Collections.Generic;

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("축구 게임을 시작합니다.");

//            // 축구 구단 이름과 선수 정보를 저장할 Dictionary 생성
//            Dictionary<string, List<string>> soccerTeams = new Dictionary<string, List<string>>();

//            // 축구 구단 수 입력 받기
//            Console.Write("총 몇 개의 축구 구단을 등록하시겠습니까?: ");
//            int totalTeams = int.Parse(Console.ReadLine());

//            // 각 구단의 선수 수 입력 받아서 Dictionary에 추가
//            for (int i = 0; i < totalTeams; i++)
//            {
//                Console.Write($"축구 구단 이름 {i + 1}: ");
//                string teamName = Console.ReadLine();

//                soccerTeams[teamName] = new List<string>();

//                Console.Write($"축구 구단 {teamName}의 선수 수: ");
//                int totalPlayers = int.Parse(Console.ReadLine());

//                for (int j = 0; j < totalPlayers; j++)
//                {
//                    Console.Write($"선수 이름 {j + 1}: ");
//                    string playerName = Console.ReadLine();
//                    soccerTeams[teamName].Add(playerName);
//                }
//            }

//            // 출력할 구단 선택
//            Console.Write("출력할 축구 구단 이름을 입력하세요: ");
//            string selectedTeam = Console.ReadLine();

//            // 선택한 구단의 선수 출력
//            Console.WriteLine($"{selectedTeam}의 선수 목록:");
//            foreach (string player in soccerTeams[selectedTeam])
//            {
//                Console.WriteLine(player);
//            }
//        }
//    }

//}
