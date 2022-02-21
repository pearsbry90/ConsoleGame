using NewPlayer;
using NewEnemy1;
using NewEnemy2;
using NewEnemy3;
using NewEnemy4;
using NewEnemy5;

Enemy1 enemy1 = new Enemy1
{
    name = "Tommy"
};
Enemy2 enemy2 = new Enemy2
{
    name = "Chuckie"
};
Enemy3 enemy3 = new Enemy3
{
    name = "Lillian"
};
Enemy4 enemy4 = new Enemy4
{
    name = "Phillip"
};
Enemy5 enemy5 = new Enemy5
{
    name = "Angelica"
};

Console.WriteLine("Challenger, Who Are You?");

Player player = new Player
{
    name = Console.ReadLine()
};

Console.WriteLine("\nWe are all very pleased to see you here " + player.name + "! We Just want to remind you, again, after completing Rugrats Seasons and Movies last week, you were automatically signed up for The Fight Club today. Whether you read the fine print, or not; here you are, and here we are. Are you ready to begin, yes or no?\n");

string answer1 = Console.ReadLine();
switch (answer1)
{
    case "yes" :
    Console.WriteLine("\nWelcome to Cynthia's Monday Night Punch Out!\n Get ready for your briefing!");
    break;
    case "no" :
    Console.WriteLine("\nQuick take him out Reptar! They have seen too much!");
    Console.WriteLine("\nYou Are Dead! Try again?");
    Environment.Exit(0);
    break;
}

Console.WriteLine("\nIf you chose to stick around then here is the deal...\nYou have options 1-4 for fighting and each one will do a set amount of damage to your opponent. Your opponent will also have a set amount of damage to defeat you! Don't die and make it through the fifth round to claim your prize, or perish and no one will ever know where you went!\nP.S. In between each stage you will have a chance to roll for some extra health in a game of chance you can participate or opt out and gain nothing!");

Console.WriteLine("\nYour first challenger " + enemy1.name + " appears and he is a scrawny thing, wearing a diaper. You say, 'I can do this. No problem!; The battle ensues!\n");

Console.WriteLine(enemy1.name + ", HP: " + enemy1.healthPoints + " Damage: " + enemy1.damageDealt);
Console.WriteLine(player.name + ", HP: " + player.healthPoints + "Damage: " + player.damageDealt);
Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) High kick + 6 - 2 Life points!\n\n");
    
    while(player.healthPoints > 0 && enemy1.healthPoints > 0 )
{

        string yourInput = Console.ReadLine();
        int numChosen = int.Parse(yourInput);

        if(numChosen == 1)
        {
        Console.WriteLine("Light punch + 2 damage!\n");
        enemy1.healthPoints = enemy1.healthPoints - 2 - player.damageDealt;
        player.healthPoints = player.healthPoints - 2;
        Console.WriteLine(enemy1.name + ", HP: " + enemy1.healthPoints + " Damage: " + enemy1.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy punch + 4 damage - 1 life point!\n");
        enemy1.healthPoints = enemy1.healthPoints - 4 - player.damageDealt;
        player.healthPoints = player.healthPoints - 3;
        Console.WriteLine(enemy1.name + ", HP: " + enemy1.healthPoints + " Damage: " + enemy1.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Light kick + 3 damage - 1 life point!\n");
        enemy1.healthPoints = enemy1.healthPoints - 3 - player.damageDealt;
        player.healthPoints = player.healthPoints - 3;
        Console.WriteLine(enemy1.name + ", HP: " + enemy1.healthPoints + " Damage: " + enemy1.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Heavy kick + 6 damage - 2 Life points!\n");
        enemy1.healthPoints = enemy1.healthPoints - 6 - player.damageDealt;
        player.healthPoints = player.healthPoints - 4;
        Console.WriteLine(enemy1.name + ", HP: " + enemy1.healthPoints + " Damage: " + enemy1.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else
    {
        player.healthPoints = player.healthPoints - 25;
        Console.WriteLine("You chose not to make an attack and " + enemy1.name + " got a powerfull blow on you be carful too many of those and you could die. Choose again!\n");
    }
}
// Giving the game an exit if you perish in battle
if(player.healthPoints <= 0)
{
    Console.WriteLine("You Are Dead! Try again?");
    Environment.Exit(0);
}

Console.WriteLine("Congratulations on your first victory against " + enemy1.name + "! because you did so well we will give you and opportunity to open a mystery box. This box could be dangerous or very helpful. It will be a random number from 1-5 each rewarding something different, and one that can hurt.");

Console.WriteLine("\nType open to open the random box!\n");

Random random1 = new Random();
int num1 = random1.Next(0,5);

string answer2 = Console.ReadLine();
switch (answer2)
{
    case "open" :
    Console.WriteLine("\nYou open the Box!");
    break;
}

if (num1 == 1)
{
    Console.WriteLine("\nSteroid shot gain: 30 health points!");
    player.healthPoints = player.healthPoints + 30;
}
else if (num1 == 2)
{
    Console.WriteLine("\nYou contracted COVID from unclean hands touching the box: lose 20 health points!");
    player.healthPoints = player.healthPoints - 20;
}
else if (num1 == 3)
{
    Console.WriteLine("\nAcquired Headgear and Protective gloves: gain 40 health points!");
    player.healthPoints = player.healthPoints + 40;
}
else if (num1 == 4)
{
    Console.WriteLine("\nBrass Knuckles what is this place?: you gain 4 damage!");
    player.damageDealt = player.damageDealt + 4;
}
else if (num1 == 5)
{
    Console.WriteLine("\nPre-workout mix you are energized and ready to go gain: 20 health points");
    player.healthPoints = player.healthPoints + 20;
}
else
{
    Console.WriteLine("\nContinue on!");
}

Console.WriteLine("\nYour second challenger " + enemy2.name + " appears looking angry, scared, and as confused as you are. He is ready to kill. You say 'Here we go again. Just get me out!' The battle ensues!\n");

Console.WriteLine(enemy2.name + ", HP: " + enemy2.healthPoints + " Damage: " + enemy2.damageDealt);
Console.WriteLine(player.name + ", HP: " + player.healthPoints + "Damage: " + player.damageDealt);
Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) High kick + 6 - 2 Life points!\n\n");
    
    while(player.healthPoints > 0 && enemy2.healthPoints > 0 )
{

        string yourInput = Console.ReadLine();
        int numChosen = int.Parse(yourInput);

        if(numChosen == 1)
        {
        Console.WriteLine("Light punch + 2 damage!\n");
        enemy2.healthPoints = enemy2.healthPoints - 2 - player.damageDealt;
        player.healthPoints = player.healthPoints - 3;
        Console.WriteLine(enemy2.name + ", HP: " + enemy2.healthPoints + " Damage: " + enemy2.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy punch + 4 damage - 1 life point!\n");
        enemy2.healthPoints = enemy2.healthPoints - 4 - player.damageDealt;
        player.healthPoints = player.healthPoints - 4;
        Console.WriteLine(enemy2.name + ", HP: " + enemy2.healthPoints + " Damage: " + enemy2.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Light kick + 3 damage - 1 life point!\n");
        enemy2.healthPoints = enemy2.healthPoints - 3 - player.damageDealt;
        player.healthPoints = player.healthPoints - 4;
        Console.WriteLine(enemy2.name + ", HP: " + enemy2.healthPoints + " Damage: " + enemy2.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Heavy kick + 6 damage - 2 Life points!\n");
        enemy2.healthPoints = enemy2.healthPoints - 6 - player.damageDealt;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(enemy2.name + ", HP: " + enemy2.healthPoints + " Damage: " + enemy2.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else
    {
        player.healthPoints = player.healthPoints - 25;
        Console.WriteLine("You chose not to make an attack and " + enemy2.name + " got a powerfull blow on you be carful too many of those and you could die. Choose again!\n");
    }
}
// Giving the game an exit if you perish in battle
if(player.healthPoints <= 0)
{
    Console.WriteLine("You Are Dead! Try again?");
    Environment.Exit(0);
}

Console.WriteLine("Congratulations on your second victory against " + enemy2.name + "! because you did so well we will give you and opportunity to open a mystery box again. This box could be dangerous or very helpful. It will be a random number from 1-5 each rewarding something different, and one that can hurt.");

Console.WriteLine("\nType open to open the random box!\n");

Random random2 = new Random();
int num2 = random2.Next(0,5);

string answer3 = Console.ReadLine();
switch (answer3)
{
    case "open" :
    Console.WriteLine("\nYou open the Box!");
    break;
}

if (num2 == 1)
{
    Console.WriteLine("\nSteroid shot gain 30 health points!");
    player.healthPoints = player.healthPoints + 30;
}
else if (num2 == 2)
{
    Console.WriteLine("\nYou contracted COVID from unclean hands touching the box: lose 20 health points!");
    player.healthPoints = player.healthPoints - 20;
}
else if (num2 == 3)
{
    Console.WriteLine("\nAcquired Headgear and Protective gloves gain 40 health points!");
    player.healthPoints = player.healthPoints + 40;
}
else if (num2 == 4)
{
    Console.WriteLine("\nBrass Knuckles what is this place? you gain 4 damage!");
    player.damageDealt = player.damageDealt + 4;
}
else if (num2 == 5)
{
    Console.WriteLine("\nPre-workout mix you are energized and ready to go gain 20 health points");
    player.healthPoints = player.healthPoints + 20;
}
else
{
    Console.WriteLine("\nContinue on!");
}

Console.WriteLine("\nYour third challenger " + enemy3.name + " appears and she muscular and mean looking, but you can tell she's physically slow. You say 'As long as I keep moving, I should have no problem.' The battle ensues!\n");

Console.WriteLine(enemy3.name + ", HP: " + enemy3.healthPoints + " Damage: " + enemy3.damageDealt);
Console.WriteLine(player.name + ", HP: " + player.healthPoints + "Damage: " + player.damageDealt);
Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) High kick + 6 - 2 Life points!\n\n");
    
    while(player.healthPoints > 0 && enemy3.healthPoints > 0 )
{

        string yourInput = Console.ReadLine();
        int numChosen = int.Parse(yourInput);

        if(numChosen == 1)
        {
        Console.WriteLine("Light punch + 2 damage!\n");
        enemy3.healthPoints = enemy3.healthPoints - 2 - player.damageDealt;
        player.healthPoints = player.healthPoints - 4;
        Console.WriteLine(enemy3.name + ", HP: " + enemy3.healthPoints + " Damage: " + enemy3.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy punch + 4 damage - 1 life point!\n");
        enemy3.healthPoints = enemy3.healthPoints - 4 - player.damageDealt;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(enemy3.name + ", HP: " + enemy3.healthPoints + " Damage: " + enemy3.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Light kick + 3 damage - 1 life point!\n");
        enemy3.healthPoints = enemy3.healthPoints - 3 - player.damageDealt;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(enemy3.name + ", HP: " + enemy3.healthPoints + " Damage: " + enemy3.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Heavy kick + 6 damage - 2 Life points!\n");
        enemy3.healthPoints = enemy3.healthPoints - 6 - player.damageDealt;
        player.healthPoints = player.healthPoints - 6;
        Console.WriteLine(enemy3.name + ", HP: " + enemy3.healthPoints + " Damage: " + enemy3.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else
    {
        player.healthPoints = player.healthPoints - 25;
        Console.WriteLine("You chose not to make an attack and " + enemy3 + " got a powerfull blow on you be carful too many of those and you could die. Choose again!\n");
    }
}
// Giving the game an exit if you perish in battle
if(player.healthPoints <= 0)
{
    Console.WriteLine("You Are Dead! Try again?");
    Environment.Exit(0);
}

Console.WriteLine("Congratulations on your third victory against " + enemy3.name + "! because you did so well we will give you and opportunity to open a mystery box again. This box could be dangerous or very helpful. It will be a random number from 1-5 each rewarding something different, and one that can hurt.");

Console.WriteLine("\nType open to open the random box!\n");

Random random3 = new Random();
int num3 = random3.Next(0,5);

string answer4 = Console.ReadLine();
switch (answer4)
{
    case "open" :
    Console.WriteLine("\nYou open the Box!");
    break;
}

if (num3 == 1)
{
    Console.WriteLine("\nSteroid shot gain 30 health points!");
    player.healthPoints = player.healthPoints + 30;
}
else if (num3 == 2)
{
    Console.WriteLine("\nYou contracted COVID from unclean hands touching the box: lose 20 health points!");
    player.healthPoints = player.healthPoints - 20;
}
else if (num3 == 3)
{
    Console.WriteLine("\nAcquired Headgear and Protective gloves gain 40 health points!");
    player.healthPoints = player.healthPoints + 40;
}
else if (num3 == 4)
{
    Console.WriteLine("\nBrass Knuckles what is this place? you gain 4 damage!");
    player.damageDealt = player.damageDealt + 4;
}
else if (num3 == 5)
{
    Console.WriteLine("\nPre-workout mix you are energized and ready to go gain 20 health points");
    player.healthPoints = player.healthPoints + 20;
}
else
{
    Console.WriteLine("\nContinue on!");
}


Console.WriteLine("\nYour fourth challenger " + enemy4.name + " appears and he has a monstrous look in his eyes, while eating worms tangled in between his clutched fingers. You think to yourself this guy definitely has a screw loose but as long as I keep on my toes I should have no problem. The battle ensues!\n");

Console.WriteLine(enemy4.name + ", HP: " + enemy4.healthPoints + " Damage: " + enemy4.damageDealt);
Console.WriteLine(player.name + ", HP: " + player.healthPoints + "Damage: " + player.damageDealt);
Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) High kick + 6 - 2 Life points!\n\n");
    
    while(player.healthPoints > 0 && enemy4.healthPoints > 0 )
{

        string yourInput = Console.ReadLine();
        int numChosen = int.Parse(yourInput);

        if(numChosen == 1)
        {
        Console.WriteLine("Light punch + 2 damage!\n");
        enemy4.healthPoints = enemy4.healthPoints - 2 - player.damageDealt;
        player.healthPoints = player.healthPoints - 4;
        Console.WriteLine(enemy4.name + ", HP: " + enemy4.healthPoints + " Damage: " + enemy4.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy punch + 4 damage - 1 life point!\n");
        enemy4.healthPoints = enemy4.healthPoints - 4 - player.damageDealt;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(enemy4.name + ", HP: " + enemy4.healthPoints + " Damage: " + enemy4.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Light kick + 3 damage - 1 life point!\n");
        enemy4.healthPoints = enemy4.healthPoints - 3 - player.damageDealt;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(enemy4.name + ", HP: " + enemy4.healthPoints + " Damage: " + enemy4.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Heavy kick + 6 damage - 2 Life points!\n");
        enemy4.healthPoints = enemy4.healthPoints - 6 - player.damageDealt;
        player.healthPoints = player.healthPoints - 6;
        Console.WriteLine(enemy4.name + ", HP: " + enemy4.healthPoints + " Damage: " + enemy4.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else
    {
        player.healthPoints = player.healthPoints - 25;
        Console.WriteLine("You chose not to make an attack and " + enemy4 + " got a powerfull blow on you be carful too many of those and you could die. Choose again!\n");
    }
}
// Giving the game an exit if you perish in battle
if(player.healthPoints <= 0)
{
    Console.WriteLine("You Are Dead! Try again?");
    Environment.Exit(0);
}

Console.WriteLine("Congratulations on your fourth victory against " + enemy4.name + "! because you did so well we will give you and opportunity to open a mystery box again. This box could be dangerous or very helpful. It will be a random number from 1-5 each rewarding something different, and one that can hurt.");

Console.WriteLine("\nType open to open the random box!\n");

Random random4 = new Random();
int num4 = random3.Next(0,5);

string answer5 = Console.ReadLine();
switch (answer5)
{
    case "open" :
    Console.WriteLine("\nYou open the Box!");
    break;
}

if (num4 == 1)
{
    Console.WriteLine("\nSteroid shot gain 30 health points!");
    player.healthPoints = player.healthPoints + 30;
}
else if (num4 == 2)
{
    Console.WriteLine("\nYou contracted COVID from unclean hands touching the box: lose 20 health points!");
    player.healthPoints = player.healthPoints - 20;
}
else if (num4 == 3)
{
    Console.WriteLine("\nAcquired Headgear and Protective gloves gain 40 health points!");
    player.healthPoints = player.healthPoints + 40;
}
else if (num4 == 4)
{
    Console.WriteLine("\nBrass Knuckles what is this place? you gain 4 damage!");
    player.damageDealt = player.damageDealt + 4;
}
else if (num4 == 5)
{
    Console.WriteLine("\nPre-workout mix you are energized and ready to go gain 20 health points");
    player.healthPoints = player.healthPoints + 20;
}
else
{
    Console.WriteLine("\nContinue on!");
}

Console.WriteLine("\nYour fifth and final challenger " + enemy5.name + " appears and she is a towering brute - fast and strong. She exclaims, 'You have no future! So Prepare to Die!' You start praying, 'Oh My God! May the Lord be with me!' Your strategy is to close your eyes and go in headfirst; no remorse! 'I should have no problem; I have made it this far,' as you get focus. The battle ensues!\n");

Console.WriteLine("Before this last fight I will give you a second chance to gain an advantage: type door 1, door 2, or door 3 to choose a door. Behind the chosen door will be either something that will increase your odds or potentially hurt you; or type no and move on to the final round!\n");

string answer7 = Console.ReadLine();
switch (answer7)
{
    case "door 1" :
    Console.WriteLine("\nInjectable rabies gain 30 health points!");
    player.healthPoints = player.healthPoints + 30;
    break;
    case "door 2" :
    Console.WriteLine("\nYou stepped on a bear trap lose 50 health points!");
    player.healthPoints = player.healthPoints - 50;
    break;
    case "door 3" :
    Console.WriteLine("\nAdamantium injection gain 40 health points!");
    player.healthPoints = player.healthPoints + 40;
    break;
    case "no" : 
    Console.WriteLine("\nYou have chosen to not take a risk move on to the final enemy!");
    break;
}

Console.WriteLine(enemy5.name + ", HP: " + enemy5.healthPoints + " Damage: " + enemy5.damageDealt);
Console.WriteLine(player.name + ", HP: " + player.healthPoints + "Damage: " + player.damageDealt);
Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) High kick + 6 - 2 Life points!\n\n");
    
    while(player.healthPoints > 0 && enemy5.healthPoints > 0 )
{

        string yourInput = Console.ReadLine();
        int numChosen = int.Parse(yourInput);

        if(numChosen == 1)
        {
        Console.WriteLine("Light punch + 2 damage!\n");
        enemy5.healthPoints = enemy5.healthPoints - 2 - player.damageDealt;
        player.healthPoints = player.healthPoints - 4;
        Console.WriteLine(enemy5.name + ", HP: " + enemy5.healthPoints + " Damage: " + enemy5.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy punch + 4 damage - 1 life point!\n");
        enemy5.healthPoints = enemy5.healthPoints - 4 - player.damageDealt;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(enemy5.name + ", HP: " + enemy5.healthPoints + " Damage: " + enemy5.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Light kick + 3 damage - 1 life point!\n");
        enemy5.healthPoints = enemy5.healthPoints - 3 - player.damageDealt;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(enemy5.name + ", HP: " + enemy5.healthPoints + " Damage: " + enemy5.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Heavy kick + 6 damage - 2 Life points!\n");
        enemy5.healthPoints = enemy5.healthPoints - 6 - player.damageDealt;
        player.healthPoints = player.healthPoints - 6;
        Console.WriteLine(enemy5.name + ", HP: " + enemy5.healthPoints + " Damage: " + enemy5.damageDealt);
        Console.WriteLine(player.name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light punch + 2 damage!\n2.) Heavy punch + 4 damage - 1 life points!\n3.) Light kick + 3 damage - 1 life points!\n4.) Heavy kick + 6 - 2 Life points!\n\n");    }
    else
    {
        player.healthPoints = player.healthPoints - 25;
        Console.WriteLine("You chose not to make an attack and " + enemy5.name + " got a powerfull blow on you be carful too many of those and you could die. Choose again!\n");
    }
}
// Giving the game an exit if you perish in battle
if(player.healthPoints <= 0)
{
    Console.WriteLine("You Are Dead! Try again?");
    Environment.Exit(0);
}

Console.WriteLine("Congratulations on your Final victory against " + enemy5.name + "! You have not only one your freedom but $1,000,000 so go enjoy yourself and try not to spend it all in one place! Maybe next time you wont take random surveys without knowing the consequences.");

Console.WriteLine("\nType escape to escape through the tunnel and finally make it out!\n");

string answer6 = Console.ReadLine();
switch (answer6)
{
    case "escape" :
    Console.WriteLine("\nYou escaped through the tunnel, into the light, into fresh air. Unknowingly, you're on nearby highway road. As soon as your eyes adjusted, understanding your surroundings, you were hit by a semi. Instantly waking up - jumping out of bed, clutching your chest! 'OMG, that was the craziest dream I had. Maybe I shouldn't fall asleep to Children Of The Corn anymore!");
    Console.WriteLine("\nTHE END!\n");
    break;
}
Environment.Exit(0);

namespace NewPlayer
{
    public class Player
    {
        public int healthPoints { get; set; }
        public int damageDealt { get; set; }
        public string name { get; set; }


        public Player()
        {
            healthPoints = 200;
            damageDealt = 0;
            name = name;
        }
    }

}
namespace NewEnemy1 
{
    public class Enemy1
    {
        public int healthPoints { get; set; }
        public int damageDealt { get; set; }
        public string name { get; set; }
    

        public Enemy1()
        {
            healthPoints = 20;
            damageDealt = 2;
            name = "Tommy";
        }
    }
}
namespace NewEnemy2 
{
    public class Enemy2
    {
        public int healthPoints { get; set; }
        public int damageDealt { get; set; }
        public string name { get; set; }
    

        public Enemy2()
        {
            healthPoints = 40;
            damageDealt = 3;
            name = "Chuckie";
        }
    }
}
namespace NewEnemy3 
{
    public class Enemy3
    {
        public int healthPoints { get; set; }
        public int damageDealt { get; set; }
        public string name { get; set; }
    

        public Enemy3()
        {
            healthPoints = 50;
            damageDealt = 4;
            name = "Lillian";
        }
    }
}
namespace NewEnemy4 
{
    public class Enemy4
    {
        public int healthPoints { get; set; }
        public int damageDealt { get; set; }
        public string name { get; set; }
    

        public Enemy4()
        {
            healthPoints = 60;
            damageDealt = 4;
            name = "Phillip";
        }
    }
}
namespace NewEnemy5 
{
    public class Enemy5
    {
        public int healthPoints { get; set; }
        public int damageDealt { get; set; }
        public string name { get; set; }
    

        public Enemy5()
        {
            healthPoints = 80;
            damageDealt = 6;
            name = "Angelica";
        }
    }
}







