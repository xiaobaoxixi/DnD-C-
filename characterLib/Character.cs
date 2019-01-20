using System;
namespace characterLib
{
    public class Character
    {
        public Character() // constructor
        {
            _strength = 3;
            _intelligence = 3;
            _wisdom = 3;
            _dexterety = 3;
            _constitution = 3;
            _charisma = 3;
        }

        public Character(string name, int str, int cons, int dex, int wis, int cha, int intelli)  // overloaded constructor
        {
            CharacterName = name;
            _strength = str;
            _wisdom = wis;
            _dexterety = dex;
            _intelligence = intelli;
            _constitution = cons;
            _charisma = cha;
        }

        private Random rnd = new Random();

        public string CharacterName { get; set; } // auto propoties. Use this if there is no logic/rules needed in getters and setters

        private int _strength; // _ is used to hint private. Use private for backing variable

        /* JAVA version of setters and getters when there are rules to apply
         *        
        public void SetStregth(int str) // use void, cuz setters don't have return
        {
            if(str >= 3 && str <= 18)
            {
                _strength = str;
            }
        }

        public int GetStrength()
        {
            return _strength;
        }
        */

        /* C# version, value is built-in */
        public int Strength
        {
            get { return _strength; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _strength = value;
                }
                else
                {
                    throw new Exception("Strength must be between 3 and 18");
                }
            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get { return Intelligence; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _intelligence = value;
                }
                else
                {
                    throw new Exception("Strength must be between 3 and 18");
                }

            }
        }

        private int _wisdom;
        public int Wisdom
        {
            get { return _wisdom; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _wisdom = value;
                }
                else
                {
                    throw new Exception("Wisdom must be between 3 and 18");
                }

            }
        }

        private int _dexterety;
        public int Dexteriry
        {
            get { return _dexterety; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _dexterety = value;
                }
                else
                {
                    throw new Exception("Dexteriry must be between 3 and 18");
                }

            }
        }

        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _constitution = value;
                }
                else
                {
                    throw new Exception("Constitution must be between 3 and 18");
                }

            }
        }

        private int _charisma;
        public int Charisma
        {
            get { return _charisma; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _charisma = value;
                }
                else
                {
                    throw new Exception("Charisma must be between 3 and 18");
                }

            }
        }

        // computed property
        public int ExperiencePoints { get; set; }
        public int Level
        {
            get { return int.Parse(Math.Floor(ExperiencePoints / 1000d).ToString()); } // d is used to tell it's decimal, int.Parse and ToString() are used to make sure the returned value meets requirement of the property
        }

        private int RollAttributeScore()
        {
            // don't do Random here, such as Random rnd2 = new Random(); cuz it will always use the same set of numbers to generate random nr. 
            // instead, do Random at the top of the class definition, which will generate new set of nrs every time it's instanciated 
            int score = rnd.Next(3, 18);

            return score;
        }
    }
}