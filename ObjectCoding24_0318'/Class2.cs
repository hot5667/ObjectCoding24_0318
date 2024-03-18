using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCoding24_0318_
{
    public enum CardKind { NORMAL = 0, SPECIAL = 1, ACE = 2, LEGEND = 3 }

    public class TCGCardDataCollection
    {
        private int[] cardData;

        public TCGCardDataCollection()
        {
            // 카드 종류를 배열에 저장, 초기값은 0으로 설정
            cardData = new int[Enum.GetValues(typeof(CardKind)).Length];
        }

        public int this[CardKind kind]
        {
            get
            {
                if (!Enum.IsDefined(typeof(CardKind), kind))
                {
                    throw new ArgumentOutOfRangeException(nameof(kind), "Invalid card kind.");
                }
                return cardData[(int)kind];
            }
            set
            {
                if (!Enum.IsDefined(typeof(CardKind), kind))
                {
                    throw new ArgumentOutOfRangeException(nameof(kind), "Invalid card kind.");
                }
                cardData[(int)kind] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tcgCardData = new TCGCardDataCollection();

            // 값을 설정
            tcgCardData[CardKind.NORMAL] = 1;
            tcgCardData[CardKind.SPECIAL] = 2;
            tcgCardData[CardKind.ACE] = 3;
            tcgCardData[CardKind.LEGEND] = 4;

            // 값을 가져와 출력
            Console.WriteLine("NORMAL: " + tcgCardData[CardKind.NORMAL]);
            Console.WriteLine("SPECIAL: " + tcgCardData[CardKind.SPECIAL]);
            Console.WriteLine("ACE: " + tcgCardData[CardKind.ACE]);
            Console.WriteLine("LEGEND: " + tcgCardData[CardKind.LEGEND]);

            // 유효하지 않은 카드 종류로 접근 시도
            try
            {
                tcgCardData[(CardKind)4] = 50; // 유효하지 않은 카드 종류
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
