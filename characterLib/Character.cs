using System;
namespace characterLib
{
    public class Character
    {
        public Character()
        {
        }

        public string CharacterName { get; set; } // auto propoties. Use this if there is no logic/rules needed in getters and setters

        private int _strength; // _ is used to hint private. Use private for backing variable

        /* JAVA version of setters and getters when there are rules to apply
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
    }
}