class Monster
{
    private int _health;

    private const int k_MaxHealth = 200;

    public int Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }
            else if (value > k_MaxHealth)
            {
                _health = k_MaxHealth;
            }
            else
            {
                _health = value;
            }
        }
    }

    public int Level { get; set; } = 1;
    public int Attack { get; set; } = 10;

    public string Name { get; private set; }

    public bool IsAlive => Health > 0;
    public int Defense => Level * 2;

    public Monster(string name)
    {
        Name = name;
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        int actualDamage = damage - Defense;
        if (actualDamage > 0)
        {
            Health -= actualDamage;
        }
    }
}