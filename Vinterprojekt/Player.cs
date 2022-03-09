using System;

public class Player
{
    public string name;//player name
    public int klass;//class as a numerical value
    public string classchoice;//class choice
    public string classname;//confirmed class choice
    public float hpmodifier;//hp increase modifier on lvl up
    public float manamodifier;//mana increase modifier on lvl up
    public float hp;//hp store
    public float mana;//mana ammount
    public int xp;//xp store
    public int lvl;//lvl store
    public float strenght;//strength store
    public float strengthmodifier;//strength increase modifier on lvl up

    public void stats()//display stats method 
    {
        hp = 100 + (lvl * 20 * hpmodifier);//Calculates your hp
        mana = 10 + (lvl * 2 * manamodifier);//Calculates your mana
        strenght = 10 + (lvl * 2 * strengthmodifier);//Calculates your strength
        Console.WriteLine($"[{name} Stats]");//flavour text
        Console.WriteLine();
        Console.WriteLine($"Health: {hp}");//Displays hp
        Console.WriteLine($"Mana: {mana}");//Displays mana
        Console.WriteLine($"Strength: {strenght}");//Displays strength
        Console.WriteLine($"Xp: {xp}/100");//Displays xp
        Console.WriteLine($"lvl: {lvl}");//Displays lvl
    }
}