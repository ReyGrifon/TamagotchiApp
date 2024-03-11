namespace TamagoshiApp
{
    /// <summary>
    /// Класс питомца тамагочи.
    /// </summary>
    public class Pet
    {

        /// <summary>
        /// Имя питомца.
        /// </summary>
        private string _name;

        /// <summary>
        /// Уровень здоровья питомца.
        /// </summary>
        private int _health;

        /// <summary>
        /// Уровень голода питомца.
        /// </summary>
        private int _hunger;

        /// <summary>
        /// Уровень голода питомца.
        /// </summary>
        private int _fatigue;

        /// <summary>
        /// Уровень счастья питомца
        /// </summary>
        private int _happiness;

        /// <summary>
        /// Возвращает или задаёт имя.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт здоровье
        /// </summary>
        public int Health
        {
            get => _health;
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

        /// <summary>
        /// Возвращает или задаёт уровень голода.
        /// </summary>
        public int Hunger
        {
            get => _hunger;
            set
            {
                if( Hunger == 0 && value < Hunger)
                {
                    Health--;
                    throw new ArgumentException("Be careful, your pet will overeat");
                }
                if( Hunger == 10 && value >= Hunger)
                {
                    Health--;
                    Happiness--;
                    throw new ArgumentException("Your pet is hungry");
                }
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Value incorrect");
                }
                _hunger = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт уровень усталости.
        /// </summary>
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

        /// <summary>
        /// Возвращает или задаёт уровень счастья.
        /// </summary>
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

        /// <summary>
        /// Конструктор класса с параметром.
        /// </summary>
        /// <param name="name">Имя питомца.</param>
        public Pet(string name)
        {
            Name = name;
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public Pet()
        {
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
        }

        /// <summary>
        /// Кормление питомца.
        /// </summary>
        public void Feed()
        {
            Hunger--;
        }

        /// <summary>
        /// Игра с питомцем.
        /// </summary>
        public void Play()
        {
            Fatigue++;
            Happiness++;
        }

        /// <summary>
        /// Отдых питомца.
        /// </summary>
        public void Sleep()
        {
            Fatigue = 0;
            Hunger++;
            Health++;
        }

        /// <summary>
        /// Лечение питомца.
        /// </summary>
        public void Heal()
        {
            Health++;
        }
    }
}
