using System;

int gamestate;//gamestate, pretty obvius 
string userResponse;//used to read the console readline


Player hero = new Player();//creates player character
hero.hp = 100;
hero.mana = 10;
hero.strenght = 10;
hero.lvl = 1;

string[] biomes = { "Skog", "Öken", "Berg", "Äng", "Grotta", "Glaciär" };
Random brand = new Random();
int bIndex = brand.Next(biomes.Length);//generates a random biome from a list




gamestate = 0;//sets gamestate to character creation

while (true)//while loop that contains the game
{
    while (gamestate == 0)//character creation gamestate
    {
        Console.WriteLine("Välkommen spelare, vad är ditt namn?");//asks for name input
        hero.name = Console.ReadLine();//reads and sets inputed name
        Console.WriteLine($"Hej {hero.name}. Vad är du för något? En ranger, knight eller mage?");//asks for class
        hero.classchoice = Console.ReadLine();
        hero.classchoice = hero.classchoice.ToLower();//reads class choice

        bool isRanger = hero.classchoice.Contains("ranger");
        bool isKnight = hero.classchoice.Contains("knight");//applies choosen class
        bool isMage = hero.classchoice.Contains("mage");
        if (isRanger == true)
        {
            hero.klass = 1;
            Console.WriteLine("Du har valt ranger som din klass. Dags att börja spelet.");
            gamestate = 1;//sets gamestate to exploration
            hero.classname = "ranger";
            hero.hpmodifier = 1.5f;
            hero.manamodifier = 1.5f;
            hero.strengthmodifier = 1.5f;//sets ranger class stats
        }
        else if (isKnight == true)
        {
            hero.klass = 2;
            Console.WriteLine("Du har valt knight som din klass. Dags att börja spelet.");
            gamestate = 1;//sets gamestate to exploration
            hero.classname = "knight";
            hero.hpmodifier = 2f;
            hero.manamodifier = 1.25f;
            hero.strengthmodifier = 2f;//sets knight class stats
        }
        else if (isMage == true)
        {
            hero.klass = 3;
            Console.WriteLine("Du har valt mage som din klass. Dags att börja spelet.");
            gamestate = 1;//sets gamestate to exploration
            hero.classname = "mage";
            hero.hpmodifier = 1.25f;
            hero.manamodifier = 2f;
            hero.strengthmodifier = 1.25f;//sets mage class stats
        }
        else
        {
            Console.WriteLine("Du verkar ha skrivit något fel, försök igen");//failsafe
        }

    }

    while (gamestate == 1)//exploration gamestate
    {
        bool explore;
        explore = true;

        Console.WriteLine("Du vaknar i en {0}", biomes[bIndex]);//spawns you in a random biome
        Console.WriteLine("Åt vilket håll vill du gå? Norr, Öst, Söder eller Väst?");//asks for a direction to travel
        userResponse = Console.ReadLine();
        userResponse = userResponse.ToLower();//reads the console

        while (explore == true)
        {
            if ((userResponse == "norr") || (userResponse == "öst") || (userResponse == "söder") || (userResponse == "väst"))//checks if user input is a valid direction
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 3);//generates a 50/50 chance
                if (value == 1)
                {
                    gamestate = 2;//sets gamestate to combat
                    break;//leaves exploration 
                }
                else
                {
                    Console.WriteLine("Du går tills du kommer fram till en {0}", biomes[bIndex], "utan problem");//moves you to a biome
                    Console.WriteLine("Åt vilket håll vill du gå? Norr, Öst, Söder eller Väst?");// askes for a direction to travel
                    bIndex = brand.Next(biomes.Length);//generates a new biome for you to travel to
                }
            }
            if (userResponse == "stats")//if you ask for stats you get them
            {
                hero.stats();
            }
            userResponse = Console.ReadLine();//reads a new direction input and returns to the top of the exploration loop
        }



    }


    while (gamestate == 2)//combat gamestate
    {
        Boolean fight;
        fight = false;



        Monster opponent = new Monster(); //creates a monster opponent
        opponent.mLvl = hero.lvl;//sets the monster lvl to your lvl

        Random rnd = new Random();
        int value = rnd.Next(1, 6);//generates a random number to pick a monster
        if (value == 1)
        {
            opponent.Orc();
        }
        else if (value == 2)
        {
            opponent.Goblin();
        }
        else if (value == 3)
        {
            opponent.Varg();
        }
        else if (value == 4)
        {
            opponent.Bandit();
        }
        else if (value == 5)
        {
            opponent.Spindel();
        }
        else if (value == 6)
        {
            opponent.Lich();
        }
        fight = true;//starts the fight

        while (fight == true)//fight loop
        {
            userResponse = Console.ReadLine();
            userResponse = userResponse.ToLower();//reads the console
            Random rps = new Random();//generates the opponents action at random between 3 actions
            int combat = rps.Next(1, 4);
            //1=attack
            //2=defend
            //3=magi
            if (userResponse == "attack" & combat == 3)//rock paper scissor win outcome 1
            {
                opponent.mHp = opponent.mHp - hero.strenght;
                Console.WriteLine("Din motståndare försöker använda magi men du attakerar för snabbt. Din motståndare tar skada. Vad vill du göra nu? Attack, Skydd eller Magi.");
            }
            else if (userResponse == "skydd" & combat == 1)//rock paper scissor win outcome 2
            {
                opponent.mHp = opponent.mHp - hero.strenght;
                Console.WriteLine("Din motståndare attakerar men du skyddar och parerar. Din motståndare tar skada. Vad vill du göra nu? Attack, Skydd eller Magi.");
            }
            else if (userResponse == "magi" & combat == 2)//rock paper scissor win outcome 3
            {
                opponent.mHp = opponent.mHp - hero.mana;
                Console.WriteLine("Din motståndare skyddar men din magi slår rakt igenom. Din motståndare tar skada. Vad vill du göra nu? Attack, Skydd eller Magi.");
            }
            else if (combat == 3 & userResponse != "attack")//rock paper scissor lose outcome 1
            {
                hero.hp = hero.hp - opponent.mMana;
                Console.WriteLine("Det du försökere göra misslyckas då motståndarens magi slår rakt igenom. Du tar skada. Vad vill du göra nu? Attack, Skydd eller Magi.");
            }
            else if ((combat == 1 & userResponse == "attack") || (combat == 2 & userResponse == "skydd") || (combat == 3 & userResponse == "magi"))//rock paper scissor draw outcome 
            {
                Console.WriteLine("Du och din motståndare gör samma sak, inget händer. Vad vill du göra nu? Attack, Skydd eller Magi.");
            }
            else
            {
                hero.hp = hero.hp - opponent.mStrength;
                Console.WriteLine("Det du försöker göra misslyckas. Du tar skada. Vad vill du göra nu? Attack, Skydd eller Magi.");//rock paper scissor lose outcome 2
            }
            Console.WriteLine($"Ditt HP: {hero.hp}");
            Console.WriteLine($"Din motståndares HP: {opponent.mHp}");//states yours and your opponents HP
            userResponse = "default";//Resets the userresponse
            if (hero.hp <= 0)//checks if you are dead at the end of a combat round
            {
                gamestate = 3;//dead gamestate
                fight = false;//breaks fight loop
            }
            else if (opponent.mHp <= 0)//checks if opponent is dead at the end of a combat round
            {
                Console.WriteLine("Du vann fighten. Grattis!!! Du svimmar av dina skador.");//flavour text
                hero.hp = hero.hp + 25;//regens some hp
                hero.xp = hero.xp + 25;//gives some xp
                if (hero.xp == 100)//checks if you pass the xp needed to gain a lvl
                {
                    hero.lvl = hero.lvl + 1;//gives that lvl if you pass
                    hero.xp = 0;//resets xp to 0
                }
                fight = false;//ends the fight because you won
                gamestate = 1;//Sets you back to the exploration gamestate
            }



        }



    }

    if (gamestate == 3)//dead gamestate
    {
        Console.WriteLine("Du dog, snyckt försök");//flavour text
        Console.ReadLine();
        break;//kills the game 
    }
}