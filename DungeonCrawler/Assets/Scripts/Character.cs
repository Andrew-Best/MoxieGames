using UnityEngine;
using System.Collections;

public class Character
{
    /// <summary>Character's equipment</summary>
    private Equipment equipment_;
    /// <summary>Character's name</summary>
    public readonly string Name;
    /// <summary>Character's hire cost (if 0 they are not hirable)</summary>
    public readonly int HireCost;
    /// <summary>Character's experience points</summary>
    private float exp_;
    /// <summary>Charater's level</summary>
    private int level_;
    /// <summary>Character's health</summary>
    private int health_;
    /// <summary>Character's mana</summary>
    private int mana_;
    /// <summary>Character's strenght</summary>
    private int str_;
    /// <summary>Character's vitality</summary>
    private int vit_;
    /// <summary>Character's dexterity</summary>
    private int dex_;
    /// <summary>Character's intelligence</summary>
    private int int_;
    /// <summary>Character's mind</summary>
    private int mnd_;
    /// <summary>Character's luck</summary>
    private int luck_;
    /// <summary>Character's attack</summary>
    private int attack_;
    /// <summary>Character's defense</summary>
    private int defense_;
    /// <summary>Cahracter's magic defense</summary>
    private int magicDefense_;
    /// <summary>Character's evasion</summary>
    private int evasion_;
    /// <summary>Flag determining whether the character is dead or not. True == dead</summary>
    private bool isDead_;

    /// <summary>Character constructor, at the end if equipment is not null it will call Calculate Stats</summary>
    /// <param name="name">Name of the character</param>
    /// <param name="level">Level of the character</param>
    /// <param name="health">Health of the character</param>
    /// <param name="mana">Mana of the character</param>
    /// <param name="str">Strength of the character</param>
    /// <param name="vit">Vitality of the character</param>
    /// <param name="intelligence">Intelligence of the character</param>
    /// <param name="mnd">Mind of the character</param>
    /// <param name="luck">Luck of the character</param>
    /// <param name="attack">Attack of the character</param>
    /// <param name="defense">Defense of the character</param>
    /// <param name="magicDefense">Magic Defense of the character</param>
    /// <param name="evasion">Evasion of the character</param>
    /// <param name="equipment">Character's equipment</param>
    public Character(string name, float exp, int level, int health, int mana, int str, int vit, int dex, int intelligence, int mnd, int luck, int attack, int defense, int magicDefense, int evasion, int hireCost, Equipment equipment)
    {
        Name = name;
        exp_ = exp;
        level_ = level;
        health_ = health;
        mana_ = mana;
        str_ = str;
        vit_ = vit;
        dex_ = dex;
        int_ = intelligence;
        mnd_ = mnd;
        luck_ = luck;
        attack_ = attack;
        defense_ = defense;
        magicDefense_ = magicDefense;
        evasion_ = evasion;
        equipment_ = equipment;
        HireCost = hireCost;

        if(equipment_ != null)
        {
            CalculateStats();
        }
    }

    /// <summary>Calculates the character's stats after being added to by the equipment</summary>
    void CalculateStats()
    {
        attack_ += equipment_.Attack + equipment_.Damage;
        str_ += equipment_.Str;
        vit_ += equipment_.Vit;
        dex_ += equipment_.Dex;
        int_ += equipment_.Int;
        mnd_ += equipment_.Mnd;
        luck_ += equipment_.Luck;
        defense_ += equipment_.Defense;
        magicDefense_ += equipment_.MagicDefense;
        evasion_ += equipment_.Evasion;
    }

    /// <summary>Calculates the damage after subtracting the character's defense</summary>
    /// <param name="damage">Damage dealt by the attack before calculations</param>
    int DamageAfterCalculation(int damage)
    {
        if (damage <= 0)
        {
            return 0;
        }
        else
        {
            int damageAfterCalc = damage - defense_;
            if (damageAfterCalc > 0)
            {
                return damageAfterCalc;
            }
            else
            { 
                return 0;
            }
        }
    }

    public int Attack()
    {
        return attack_;
    }

    /// <summary>Applies damage to the character</summary>
    /// <param name="damage">Amount of damage to deal to the character</param>
    public void TakeDamage(int damage)
    {
        int damageAfterCalc = DamageAfterCalculation(damage);
        if ((health_ - damageAfterCalc) > 0)
        {
            health_ -= damageAfterCalc;
        }
        else
        {
            health_ = 0;
            isDead_ = true;
        }
    }

    /// <summary>Gives experience to the character</summary>
    /// <param name="amt">Amount of experience points to give</param>
    public void GiveExp(float amt)
    {
        exp_ += amt;
        CheckLevel();
    }

    /// <summary>Checks for a level up every time the character receives experience</summary>
    void CheckLevel()
    {
        if(exp_ >= (Constants.EXP_INCREASE_PER_LEVEL * level_))
        {
            exp_ = 0;
            level_ += 1;
        }
    }

    /// <summary>Displays character information for debug purposes</summary>
    public string DisplayInformation()
    {
        if (equipment_ != null)
        {
            return Name + "\n" + level_ + "\n" + exp_ + "\n" + health_ + "\n" + mana_ + "\n" + str_ + "\n" + vit_ + "\n" + dex_ + "\n" + int_ + "\n" + mnd_ + "\n" + luck_ + "\n" + attack_ + "\n" + defense_ + "\n" + magicDefense_ + "\n" + evasion_ + "\n" + equipment_.Name + "\n" + isDead_;
        }
        else
        {
            return Name + "\n" + level_ + "\n" + exp_ + "\n" + health_ + "\n" + mana_ + "\n" + str_ + "\n" + vit_ + "\n" + dex_ + "\n" + int_ + "\n" + mnd_ + "\n" + luck_ + "\n" + attack_ + "\n" + defense_ + "\n" + magicDefense_ + "\n" + evasion_ + "\nnull\n" + isDead_;
        }
    }
}