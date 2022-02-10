Console.WriteLine("Create Your Name");
string playerName = Console.ReadLine();
Console.WriteLine("You came home and noticed your dog, Froggy, not at the door waiting for you. Upon your search, you glanced outside and see Froggy at your neighbors house. They kidnapped Froggy again!");
string bossName = "Karen";
string [] bosses = new string [] {bossName, "Kyle", "Becky", "Cory"};
foreach(string name in bosses)
{
    Console.WriteLine($"Save your dog from your pestering neighbors {name}");
}

Console.WriteLine("\nPrepare for war " + playerName + "!" + " Your dog, Froggy, been stolen by Karen and her evil family! He is in need of rescuing!\n\nIf yes then type YES to enter the house of death to retrieve him!\nOr choose NO and let your dog cry it'll never see you again.\n");
string answer1 = Console.ReadLine();
switch(answer1)
{
    case "yes":
    Console.WriteLine("\nGo Save Froggy; and don't die in there!");
    break;
    case "no":
    Console.WriteLine("\nToo Bad!");
    break;
}

Console.WriteLine("Now " + playerName + " your objective is to get in, defeat the evil family and rescue poor Froggy from the clutches of the almighty and vile Karen. To do this you will be prompted to choose an action number from 1-5 to increase your chances of making it out of this house full of NAGGING and DEATH! as you progress you may have the option for an enhancer at the expense of life points choose wisely and you shall defeat her with ease or make the wrong choice and perish leaving Froggy all alone with no one to save him.\n\nBelow are your actions!\n\n1.) Light Attack + 2 damage!\n2.) Heavy Attack + 4 damage - 1 life point!\n3.) Defend - .5 life point!\n4.) Special Move + 8 damage - 3.5 Life points!\n\nIf you need to reference these actions just scroll back up to here.");