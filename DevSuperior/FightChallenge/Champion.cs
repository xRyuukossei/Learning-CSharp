using System;

namespace FightChallenge;
internal class Champion
{
    private string _name;
    private int _attack;
    private int _armor;
    public int Life { get; private set; }

    public Champion(string name, int attack, int armor, int life)
    {
        _name = name;
        _attack = attack;
        _armor = armor;
        Life = life;
    }
    public void TakeDamage(int attack)
    {
        if (_armor >= attack)
        {
            Life -= 1;
        }
        else
        {
            Life -= (attack - _armor);
        }
    }
    public string Status()
    {
        if (Life <= 0)
        {
            return _name + ": " + 0 + " health (died)";
        }
        else
        {
            return _name + ": " + Life + " health";
        }
    }
}
