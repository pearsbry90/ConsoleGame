Console.WriteLine("Create Your Name");
string playerName = Console.ReadLine();
Console.WriteLine("You came home and noticed your puppy, Froggy, not at the door waiting for you. Upon your search, you glanced outside and see Froggy at your neighbor's house. They kidnapped Froggy!");
string bossName = "Karen";
string [] bosses = new string [] {"Cory", "Becky", "Kyle", bossName};
foreach(string name in bosses)
{
    Console.WriteLine($"Save Froggy from your awful neighbors {name}");
}

Console.WriteLine("\nPrepare for war " + playerName + "!" + " Froggy been stolen by Karen and her evil family! He is in need of rescuing!\n\nAre you ready for battle? If yes then type YES to go to their 'House of Death!'\nOr type NO and let your puppy cry it'll never see you again.\n");
string answer1 = Console.ReadLine();
switch(answer1)
{
    case "yes":
    Console.WriteLine("\nGo Save Froggy!");
    break;
    case "no":
    Console.WriteLine("\nToo Bad!");
    break;
}
// Tutorial for how to win/lose the game
Console.WriteLine("Now " + playerName + ", your objective is to get in, defeat the evil family, and rescue poor Froggy from the clutches of the almighty and vile Karen. To do this you will be prompted to choose an action number from 1-4 to increase your chances of making it out of this house full of NAGGING and DEATH! As you progress you may have the option for an enhancer at the expense of life points. Choose wisely and you shall defeat her with ease, or make the wrong choice and perish leaving Froggy all alone with no one to save him.\n\nBelow are your actions!\n\n1.) !\n2.)!\n3.) !\n4.) !\n");

Console.WriteLine("As you approach the house you come up on an item box with a message saying 'Please Open! But Be Cautious!' Do you open it, yes or no?\n");
string openBox = Console.ReadLine();
switch(openBox)
{
    case "yes":
    Console.WriteLine("\nYou have been rewarded Body Armor! Your muscles increased to the size of The Rock. You continue entering the house.\n");
    break;
    case "no":
    Console.WriteLine("\nYou leave the box closed, worrying that something dangerous could have been placed inside. You exclame 'I am not falling for that, Karen, HAHA'; and move on.\n");
    break;
}
Console.WriteLine("As you make your way into the house you notice that the house has a strong smell of entitlement and rage.\n\nYou continue forward, distracted by a ceiling vent, hearing people arguing through it. Do you want to listen in or keep exploring? Yes or No?\n\n");
string listenTo = Console.ReadLine();
switch(listenTo)
{
    case "yes":
    Console.WriteLine("\nYou strain to put your ear to the vent and hear the shrill shrieks of Karen arguing with Kyle. Your ears start to bleed! You're already taken damaged and no one hit you. Foolish Decision.\n");
    break;
    case "no":
    Console.WriteLine("\nYou're glad they're distracted. However, still keeping watch for Froggy, you're on guard for Cory and Becky.\n");
    break;
}

Console.WriteLine("Turning into the living room, you run into Cory watching Wife Swap.\n\n It's life or death, do you battle? Yes or No\n\n");
string battleCory = Console.ReadLine();
switch(battleCory)
{
    case "yes":
    Console.WriteLine("Ooh Yeah!");
    break;
    case "no":
    Console.WriteLine("Too late! Cory lungs towards you and the fight begins.");
    break;
}

Console.WriteLine("Turning into the kitchen, you run into Becky making a vegan, gluten free, kale and lemon juice.\n\n It's life or death, do you battle? Yes or No\n\n");
string battleBecky = Console.ReadLine();
switch(battleBecky)
{
    case "yes":
    Console.WriteLine("");
    break;
    case "no":
    Console.WriteLine("");
    break;
}

Console.WriteLine("Turning into the bathroom, you run into Kyle wiping away his tears from Karen screaming at him.\n\n It's life or death, do you battle? Yes or No\n\n");
string battleKyle = Console.ReadLine();
switch(battleKyle)
{
    case "yes":
    Console.WriteLine("");
    break;
    case "no":
    Console.WriteLine("");
    break;
}

Console.WriteLine("After your defeat, getting your breath back, you can hear Froggy whimpering nearby.\n Running to where you believe you hear his cry, you stop in the laundry room.\n Walls with only one entry, you start freaking out.\n Getting angry, you start raging - kicking the washer machine and dryer, and knocking down laundry soap bottles.\n Froggy starts crying louder! Then total silence.\n 'I'm going to call your mom if you don't get out of my house!' you hear Karen say, as she's blocking the entrance, while holding Froggy in a cat cage.\n Thinking of your options, you make a decision of either letting your mom being called , or handling Karen, like you did her family.\n What will you do " + playerName + "?" + "\n Call or Fight?\n\n");
string battleKaren = Console.ReadLine();
switch(battleKaren)
{
    case "call":
    Console.WriteLine(bool};
    bool isMomUnderstanding = true;
    bool isHandleKaren = false;

    if (isMomUnderstanding)
    {
    Console.WriteLine("Sweet deal!\n Your mom is rushing to your aid because she's the one who gifted you Froggy!");
    }
    if (isMomUnderstanding || isHandleKaren)
    {
    Console.WriteLine("Smirking in Karen's face, you patiently wait for another victory, but not by your own hands.");
}
    break;
    case "fight":
    Console.WriteLine("");
Console.WriteLine("CONGRULATIONS!!\n Froggy is back in your hands and the Karen family have been defeated!!");