using UnityEngine;
using System.Collections;

public class Equipment 
{
    /// <summary>Equipment's name</summary>
    public readonly string Name;
    /// <summary>Equipment's damage</summary>
    public readonly int Damage;
    /// <summary>Equipment's strenght</summary>
    public readonly int Str;
    /// <summary>Equipment's vitality</summary>
    public readonly int Vit;
    /// <summary>Equipment's dexterity</summary>
    public readonly int Dex;
    /// <summary>Equipment's intelligence</summary>
    public readonly int Int;
    /// <summary>Equipment's mind</summary>
    public readonly int Mnd;
    /// <summary>Equipment's luck</summary>
    public readonly int Luck;
    /// <summary>Equipment's attack</summary>
    public readonly int Attack;
    /// <summary>Equipment's defense</summary>
    public readonly int Defense;
    /// <summary>Cahracter's magic defense</summary>
    public readonly int MagicDefense;
    /// <summary>Equipment's evasion</summary>
    public readonly int Evasion;

    /// <summary>Equipment constructor</summary>
    /// <param name="damage">Equipment's damage</param>
    /// <param name="str">Equipment's bonus strength</param>
    /// <param name="vit">Equipment's bonus vitality</param>
    /// <param name="dex">Equipment's bonus dexterity</param>
    /// <param name="intelligence">Equipment's bonus intelligence</param>
    /// <param name="mnd">Equipment's bonus mind</param>
    /// <param name="luck">Equipment's bonus luck</param>
    /// <param name="attack">Equipmet's bonus attack</param>
    /// <param name="defense">Equipment's bonus defense</param>
    /// <param name="magicDefense">Equipment's bonus magic defense</param>
    /// <param name="evasion">Equipment's bonus evasion</param>
    public Equipment(string name, int damage, int str, int vit, int dex, int intelligence, int mnd, int luck, int attack, int defense, int magicDefense, int evasion)
    {
        Name = name;
        Damage = damage;
        Str = str;
        Vit = vit;
        Dex = dex;
        Int = intelligence;
        Mnd = mnd;
        Luck = luck;
        Attack = attack;
        Defense = defense;
        MagicDefense = magicDefense;
        Evasion = evasion;
    }
}