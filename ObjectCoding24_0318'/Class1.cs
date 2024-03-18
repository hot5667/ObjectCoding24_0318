using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCoding24_0318_
{
    public class ArgumentOutOfRangeException : Exception
    {
        public ArgumentOutOfRangeException(string message) : base(message)
        {
        }
    }

    public class FPSPlayer
    {
        private string name;
        private float atk;
        private float defense;
        private int hp;
        private int level;

        public FPSPlayer(string _name, float _atk, float _defense, int _hp, int _level)
        {
            Name = _name;
            Atk = _atk;
            Defense = _defense;
            Hp = _hp;
            Level = _level;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "PRGPlayer")
                    name = value;
                else
                    throw new ArgumentOutOfRangeException("name의 범위가 벗어났습니다.");
            }
        }

        public float Atk
        {
            get { return atk; }
            set
            {
                if (value >= 0 && value <= 1000)
                    atk = value;
                else
                    throw new ArgumentOutOfRangeException("Atk의 범위가 벗어났습니다.");
            }
        }

        public float Defense
        {
            get { return defense; }
            set
            {
                if (value >= 0 && value <= 500)
                    defense = value;
                else
                    throw new ArgumentOutOfRangeException("Def의 범위가 벗어났습니다.");
            }
        }

        public int Hp
        {
            get { return hp; }
            set
            {
                if (value >= 0 && value <= 100000)
                    hp = value;
                else
                    throw new ArgumentOutOfRangeException("Hp의 범위가 벗어났습니다.");
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value >= 0 && value <= 1000)
                    level = value;
                else
                    throw new ArgumentOutOfRangeException("Level의 범위가 벗어났습니다.");
            }
        }


        public object this[string PlayerStatusInfo]
        {
            get
            {
                switch (PlayerStatusInfo)
                {
                    case "Name":
                        return Name;
                    case "Atk":
                        return Atk;
                    case "Defense":
                        return Defense;
                    case "Hp":
                        return Hp;
                    case "Level":
                        return Level;
                    default:
                        throw new ArgumentOutOfRangeException("범위가 벗어났습니다.");
                }
            }
            set
            {
                switch (PlayerStatusInfo)
                {
                    case "Name":
                        Name = (string)value;
                        break;
                    case "Atk":
                        Atk = (float)value;
                        break;
                    case "Defense":
                        Defense = (float)value;
                        break;
                    case "Hp":
                        Hp = (int)value;
                        break;
                    case "Level":
                        Level = (int)value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("");
                }
            }


        }


        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    FPSPlayer player = new FPSPlayer("Test", 800f, 200f, 10000, 500);
                    Console.WriteLine("Player name: " + player.Name);
                    Console.WriteLine("Player attack: " + player.Atk);
                    Console.WriteLine("Player defense: " + player.Defense);
                    Console.WriteLine("Player HP: " + player.Hp);
                    Console.WriteLine("Player level: " + player.Level);

                    player.Defense = -250;
                    player.Hp = -250;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.Message);
                }
            }
        }

    }
}
