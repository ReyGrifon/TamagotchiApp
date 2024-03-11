namespace TamagoshiApp
{
    public class Pet
    {
        private string _name;
        private int _health;
        private int _hunger;
        private int _fatigue;
        private int _happiness;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                _name = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if(value == 0)
                {
                    _health = value;
                    throw new ArgumentException("Your Pet is sick");
                }
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Value incorrect");
                }
                _health = value;
            }
        }

        public int Hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                if( Hunger == 0 && value < Hunger)
                {
                    Health--;
                    throw new ArgumentException("Be careful, your pet will overeat");
                }
                if( Hunger == 10)
                {
                    Health--;
                    throw new ArgumentException("Your pet is hungry");
                }
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Value incorrect");
                }
                _hunger = value;
            }
        }

        public int Fatigue
        {
            get => _fatigue;
            set
            {
                if (Fatigue == 10 && value != 0)
                {
                    Health--;
                    Hunger++;
                    throw new ArgumentException("Be careful, your pet is tired");
                }
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Value incorrect");
                }
                _fatigue = value;
            }
        }

        public int Happiness
        {
            get => _happiness;
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Value incorrect");
                }
                _happiness = value;
            }
        }

        public Pet(string name)
        {
            Name = name;
            Health = 10;
        }
    }
}
