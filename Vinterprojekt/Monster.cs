using System;

public class Monster
{
    public float mHp;//monster hp value
    public float mMana;//monster mana value
    public float mStrength;//monster strength value
    public float mLvl;//monster lvl

    public void Orc()
    {
        Console.WriteLine("Du möter en Orc, va vill du göra? Attack, Magi eller Skydd");
        mHp = 50 + (mLvl * 20);//calculates monster hp
        mMana = 3 + (mLvl * 2);//calculates monster mana
        mStrength = 7 + (mLvl * 2);//calculates mosnter strength
        Console.WriteLine($"[Orc Stats]");//displays monster stats, same as player
        Console.WriteLine();
        Console.WriteLine($"Health: {mHp}");
        Console.WriteLine($"Mana: {mMana}");
        Console.WriteLine($"Strength: {mStrength}");
        Console.WriteLine($"lvl: {mLvl}");
    }
    public void Goblin()
    {
        Console.WriteLine("Du möter en Goblin, va vill du göra? Attack, Magi eller Skydd");
        mHp = 20 + (mLvl * 20);
        mMana = 2 + (mLvl * 2);
        mStrength = 2 + (mLvl * 2);
        Console.WriteLine($"[Goblin Stats]");
        Console.WriteLine();
        Console.WriteLine($"Health: {mHp}");
        Console.WriteLine($"Mana: {mMana}");
        Console.WriteLine($"Strength: {mStrength}");
        Console.WriteLine($"lvl: {mLvl}");
    }
    public void Varg()
    {
        Console.WriteLine("Du möter en Varg, va vill du göra? Attack, Magi eller Skydd");
        mHp = 30 + (mLvl * 20);
        mMana = 1 + (mLvl * 2);
        mStrength = 5 + (mLvl * 2);
        Console.WriteLine($"[Varg Stats]");
        Console.WriteLine();
        Console.WriteLine($"Health: {mHp}");
        Console.WriteLine($"Mana: {mMana}");
        Console.WriteLine($"Strength: {mStrength}");
        Console.WriteLine($"lvl: {mLvl}");
    }
    public void Bandit()
    {
        Console.WriteLine("Du möter en Bandit, va vill du göra? Attack, Magi eller Skydd");
        mHp = 40 + (mLvl * 20);
        mMana = 4 + (mLvl * 2);
        mStrength = 4 + (mLvl * 2);
        Console.WriteLine($"[Bandit Stats]");
        Console.WriteLine();
        Console.WriteLine($"Health: {mHp}");
        Console.WriteLine($"Mana: {mMana}");
        Console.WriteLine($"Strength: {mStrength}");
        Console.WriteLine($"lvl: {mLvl}");
    }
    public void Spindel()
    {
        Console.WriteLine("Du möter en Spindel, va vill du göra? Attack, Magi eller Skydd");
        mHp = 25 + (mLvl * 20);
        mMana = 2 + (mLvl * 2);
        mStrength = 3 + (mLvl * 2);
        Console.WriteLine($"[Spindel Stats]");
        Console.WriteLine();
        Console.WriteLine($"Health: {mHp}");
        Console.WriteLine($"Mana: {mMana}");
        Console.WriteLine($"Strength: {mStrength}");
        Console.WriteLine($"lvl: {mLvl}");
    }
    public void Lich()
    {
        Console.WriteLine("Du möter en Lich, va vill du göra? Attack, Magi eller Skydd");
        mHp = 50 + (mLvl * 20);
        mMana = 7 + (mLvl * 2);
        mStrength = 3 + (mLvl * 2);
        Console.WriteLine($"[Lich Stats]");
        Console.WriteLine();
        Console.WriteLine($"Health: {mHp}");
        Console.WriteLine($"Mana: {mMana}");
        Console.WriteLine($"Strength: {mStrength}");
        Console.WriteLine($"lvl: {mLvl}");
    }
}