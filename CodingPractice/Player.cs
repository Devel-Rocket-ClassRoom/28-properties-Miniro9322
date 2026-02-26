namespace case1
{
    class Player
    {
        public int Health;
    }
}

namespace case2
{
    class Player
    {
        private int _health;

        public void SetHealth(int health)
        {
            if(health < 0)
            {
                this._health = 0;
            }
            else if(health > 100)
            {
                this._health = 100;
            }
            else
            {
                this._health = health;
            }
        }

        public int GetHealth()
        {
            return this._health;
        }
    }
}

namespace case3
{
    class Player
    {
        public string Name { get; set; } = "플레이어";
        public int Level { get; set; } = 1;
        public int MaxHealth { get; set; } = 100;
    }
}

namespace case4
{
    class Player
    {
        private int _health;

        public int Health
        {
            get { return this._health; }
            set
            {
                if(value < 0)
                {
                    this._health = 0;
                }
                else if(value > 100)
                {
                    this._health = 100;
                }
                else
                {
                    this._health = value;
                }
            }
        }
    }
}