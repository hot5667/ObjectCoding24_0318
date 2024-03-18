//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectCoding24_0318_
//{
//    class GeneralNameInput
//    {
//        public static List<string> GetGeneralNames()
//        {
//            List<string> generals = new List<string>();

//            Console.WriteLine("다섯 명의 장수 이름을 입력해주세요:");

//            // 5명의 장수 이름 입력 받기
//            for (int i = 0; i < 5; i++)
//            {
//                Console.Write($"이름을 입력해주세요 {i + 1} : ");
//                string name = Console.ReadLine();
//                generals.Add(name);
//            }

//            return generals;
//        }
//    }

//    class GeneralNameSorter
//    {
//        public static void SortGeneralNames(List<string> generals)
//        {
//            // 이름 길이가 작은 순서로 정렬
//            generals.Sort((x, y) =>
//            {
//                if (x.Length == y.Length)
//                {
//                    // 길이가 같으면 사전순으로 정렬
//                    return x.CompareTo(y);
//                }
//                return x.Length.CompareTo(y.Length);
//            });
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> generals = GeneralNameInput.GetGeneralNames();
//            GeneralNameSorter.SortGeneralNames(generals);

//            // 정렬된 장수 이름 출력
//            Console.WriteLine("\n장수 이름을 글자 수가 작은 순서대로 정렬하여 출력합니다. (만약 글자 수가 같은 경우에는 알파벳 순서로 정렬됩니다.)");
//            foreach (string general in generals)
//            {
//                Console.WriteLine(general);
//            }
//        }
//    }


//}
