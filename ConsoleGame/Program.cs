Console.WriteLine("Create Your Name");
string playerName = Console.ReadLine();
Console.WriteLine("You came home and noticed your puppy, Froggy, not at the door waiting for you. Upon your search, you look outside and see Froggy at your neighbor's house. They kidnapped Froggy!");
string mainBoss = "Karen";
string [] bosses = new string [] {"Cory", "Becky", "Kyle", mainBoss};
foreach(string name in bosses)
{
    Console.WriteLine($"Save Froggy from your awful neighbors {name}");
}

Console.WriteLine("\nPrepare for war " + playerName + "!" + " Froggy been stolen by Karen and her evil family! He is in need of rescuing!\n\nAre you ready for battle? If yes then type YES to go to their 'House of Death!'\nOr type NO and let your puppy cry it'll never see you again.\n\n");
string answer1 = Console.ReadLine();
switch(answer1)
{
    case "yes":
    Console.WriteLine("Go Save Froggy!");
    break;
    case "no":
    Console.WriteLine("Too Bad!");
    break;
}

// Tutorial for how to win/lose the game
Console.WriteLine("Now " + playerName + ", your objective is to get in, defeat the evil family, and rescue Froggy, from the clutches of the almighty and vile Karen.\n To do this you will be given a numerical range to choose from and find the outcome of your choice!\n\n");
Console.WriteLine("As you approach the house you come up on an item box with a message saying 'Please Open! But Be Cautious!' Do you open it, yes or no?\n\n"); 

string openBox = Console.ReadLine();
switch(openBox)
{
    case "yes":
    Console.WriteLine("\nYou have been rewarded an extra key! You unlock the front door and enter the house.");
    break;
    case "no":
    Console.WriteLine("\nUncertain how to get in the house, you walk around to the side garage. Breaking the door's window, you stick your hand through the broken glass to unlock that door. Your hope came true, as the entry to the house door is unlock. You enter the house.");
    break;
}
Console.WriteLine("As you make your way into the house you notice that the house has a strong smell of entitlement and rage, and you hate it.\n You continue forward, distracted by a ceiling vent, hearing people arguing through it. Do you want to listen in, or keep exploring? Yes or No?\n\n");
string listenTo = Console.ReadLine();
switch(listenTo)
{
    case "yes":
    Console.WriteLine("You strain to put your ear to the vent and hear the shrill shrieks of Karen arguing with Kyle. Your ears start to bleed! You're already taken damaged and no one hit you. Foolish Decision.");
    break;
    case "no":
    Console.WriteLine("You're glad they're distracted. However, still keeping watch for Froggy, you're on guard for Cory and Becky.");
    break;
}

// The Battles: Cory
Console.WriteLine("Turning into the living room, you run into Cory watching Wife Swap.\n Going to school with him, you know that he knows you know he has a losing stretch in wrestling, but is still strong.\n He sees you and stands up, fist clutching, smirk on his face as he's been waiting to fight you.\n Lugging at each other, the battle begins!\n\n");
Console.WriteLine(playerName + " You have encountered Cory and he is coming for blood! What will you do?\n Choose a number from 1 - 15.\n\n");
string response = System.Console.ReadLine();
int pick = int.Parse(response);
string output = pick <= 9 ? "Dang, where did this strength come from?." : "Such an easy fight, you totally forgot how weak Cory is.";
Console.WriteLine(output);
if (pick <= 11)
{
    Console.WriteLine("The fight is not going the way you thought. As you both stand there, deep breathing, you fast-forward in your head for a special, unprepared move that'll help you win. Yes,Wrestling, your favorite Wrestler, Stone Cold Steve Austin! Slowly gettin closer to until you're at the right distance and kick him in his stomach, spins to grab his head and drop, hard, on the ground. `Stone Cold Stunner` you executed on him! He's out! You Win!");
}
else
{
    Console.WriteLine("You elbow Cory in the head, spinning him off balance. You end is tv watching by smashing his head in it. His victory is Cancelled!");
}
Console.WriteLine("VICTORY!! One down, three more to go."); 

// The Battles: Becky
Console.WriteLine("After collecting yourself, you rush to the next room, the kitchen, not seeing Becky sitting at the kitchen table drinking her gluten free, kale, ginger smoothy.\n Without missing a beat, you throw yourself on the ground because Becky threw her glass cup of juice at you.\n Lugging towards you, you hurry off the floor to fight Becky.\n\n");
Console.WriteLine(playerName + " You have encountered Becky and she is coming for blood! What will you do?\n Choose a number from 1 - 15.\n\n");
string response1 = System.Console.ReadLine();
int pick1 = int.Parse(response1);
string output1 = pick1 <= 9 ? "Girl Got Nails! But you, you got fire burning in your heart." : "Like brother like sister.";
Console.WriteLine(output1);
if (pick <= 11)
{
    Console.WriteLine("Running around the kitchen has become your best options. Your face, neck, and arms are screaming of cuts from Becky. Looking around for something, you see a cell phone on the kitchen table where Becky was sitting. Her Phone! You dash towards it, Becky not knowing what's going on, you grab her phone, hand held high. Becky stops out of fear. Pleaing for you not to break it, but you don't care about Becky. SMASH!! Thrown to the the wall, exploding her phone. She crumbles to its aid, losing it on the phone in tears. You Broke Becky.");
}
else
{
    Console.WriteLine("The kitchen is a danger place for the both of you, for this fight. Thrown on the table, knocking down kitchen ornaments, stove being turned on to burn Becky's hand. Badly wounded, Becky realized she won't win this round. Trying to get away, you try one more thing. Finding a knife in the sink, surrounded by cut up veggies and fruits, you take it. Heading towards Becky, you grab her by the hair and start hacking at her hair! Bald spots and uneven hair ended the fight. Brutality! You leave her in her tears.");
}
Console.WriteLine("VICTORY!! Two down, two more to go."); 

// The Battles: Kyle
Console.WriteLine("Needing to hide and catch a breath, clean up a little, you scan the house for the bathroom.\n Located and closed the door behind you.\n While using the sink, Kyle opens the door to find you in it.\n\n");
Console.WriteLine(playerName + " You have encountered Kyle and he is coming for blood! What will you do?\n Choose a number from 1 - 15.\n\n");
string response2 = System.Console.ReadLine();
int pick2 = int.Parse(response2);
string output2 = pick2 <= 11 ? "You have found a stronger opponent." : "Think Think Think! Now What?";
Console.WriteLine(output2);
if (pick <= 9)
{
    Console.WriteLine("As he reaches to grab you by the shirt, you're already on guard. Toilet plugger hiding in your left hand, you swing it and hit him in the head. While he's catching his balance, you plunge his face, running forward, causing him to fall back and twist his ankle. Weapons are your friends because they be helping you win.");
}
else
{
    Console.WriteLine("Not giving up, you remember the argument Karen and Kyle had. Screeching to the top of your lungs, Kyle's caught off guard. Making up some sob story about why you have to get Froggy back, and promise to buy him a gift card for a date night, you hope he just let you go and directs you to Karen.\n Kyle not caring and still angry with you, he reaches to grab you by the shirt, you're already on guard. Toilet plugger hiding in your left hand, you swing it and hit him in the head. While he's catching his balance, you plunge his face, running forward, causing him to fall back and twist his ankle. Weapons are your friends because they be helping you win.");
}
Console.WriteLine("VICTORY!! Three down, one more to go."); 


// The Battles: Karen
Console.WriteLine("After your defeat, getting your breath back, you can hear Froggy whimpering nearby.\n Running to where you believe you hear his cry, you stop in the laundry room.\n Walls with only one entry, you start freaking out.\n Getting angry, you start raging - kicking the washer machine and dryer, and knocking down laundry soap bottles.\n Froggy starts crying louder! Then total silence.\n 'I'm going to call your mom if you don't get out of my house!' you hear Karen say, as she's blocking the entrance, while holding Froggy in a cat cage.\n Thinking of your options, you make a decision of either letting your mom being called , or handling Karen, like you did her family.\n What will you do " + playerName + "?" + "\n Choose a number from 1 - 15.\n\n");
string response3 = System.Console.ReadLine();
int pick3 = int.Parse(response3);
string output3 = pick2 <= 9 ? "Yep, she's calling the manager, aka Mother." : "Go Orangutan on her.";
Console.WriteLine(output3);
if (pick <= 9)
{
    Console.WriteLine("Pulling out her cell phone, she dials your mother to deliver the news. As you hear your mother say 'Hello', you jump on Karen and snatch the phone out of her hand. Overpowering brittled Karen, you tell Mother every thing and plead for her rescue. She's leaving work and heading in your direction to tell Karen off. Karen opened the cage to watch Froggy leap in the sky towards you. What a thrill for turning tables on Karen.");
}
else
{
    Console.WriteLine("Karen is weak. All talk, but no walk. Appearing big, Karen drops the cat cage and cries running away, calling for Kyle. Froggy is now back in your arms! ");
}   
Console.WriteLine("CONGRULATIONS!! YOU ARE VICTORIOUS!!");