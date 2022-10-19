Console.Clear();


string[] breakfast = {"Denny's", "BiscuitVille", "Cracker Barrel", "Waffle House", "IHOP", "The Original Pancake House", "Black Bear Diner", "Huddle House", "Snooze", "The Flying Biscuit"};
string[] dinner = {"Olive Garden", "The Cheesecake Factory", "Texas Roadhouse", "Red Lobster", "Outback Steakhouse", "Buffalo Wild Wings", "Longhorn Steakhouse", "Red Robin", "Chili's", "Applebee's"};
string[] fastFood = {"Five Guys", "Arby's", "McDonald's", "Carl's Jr.", "Dairy Queen", "Popeyes", "In-N-Out", "Jack in the Box", "Smashburger", "Dominos Pizza"};

bool play = true;
while (play)
{

    Console.WriteLine("Choose one of the three categories below or enter \"Random\" for the program to choose one for you.\n\nBreakfast\nDinner\nFast Food\n");

    bool categoryLoop = true;
    while (categoryLoop)
    {
        string input = Console.ReadLine().ToLower();

        if (input == "breakfast" || input == "dinner" || input == "fast food" || input == "random") categoryLoop = RandomizeRestaurant(input);
        else Console.WriteLine("INVALID INPUT!\nEnter one of the options above.");

    }

    Console.WriteLine("Would you like to find another resaurant? Yes or No");

    bool playValidInput = false;
    while (!playValidInput)
    {
        string playInput = Console.ReadLine().ToLower();

        if (playInput == "yes")
        {
            playValidInput = true;
        }
        else if (playInput == "no")
        {
            playValidInput = true;
            play = false;
            Console.WriteLine("Have a great day");
        }
        else Console.WriteLine("INVALID INPUT!\nEnter Yes or No.");
    }
}


bool RandomizeRestaurant(string category)
{
    int catIndex;
    int index = 0;
    Random rnd = new Random();

    if (category == "breakfast") catIndex = 0;
    else if (category == "dinner") catIndex = 1;
    else if (category == "fast food") catIndex = 2;
    else catIndex = rnd.Next(3);

    index = rnd.Next(10);

    switch (catIndex)
    {
        case 0:
            Console.WriteLine($"\n{breakfast[index]}\n");
        break;
        case 1:
            Console.WriteLine($"\n{dinner[index]}\n");
        break;
        case 2:
            Console.WriteLine($"\n{fastFood[index]}\n");
        break;
        default:
            Console.WriteLine($"\nError! catIndex = {catIndex}, out of index limit\n");
        break;
    }

    return false;

}