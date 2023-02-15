int userChoice = GetUserChoice();
while(userChoice != 3){
    Route(userChoice);
    userChoice = GetUserChoice();
}
//End Main

//User Choice
static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
    
}
//Display Menu
static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

//Valid Choice Check
static bool IsValidChoice(string userChoice){
    if(userChoice == "1" || userChoice == "2" || userChoice == "3"){
        return true;
    }
    return false;
}

//Say Choice is Invalid
static void SayInvalid(){
    System.Console.WriteLine("Invalid: Please enter 1, 2, or 3");
    PauseAction();
}

//Route for menu choice

static void Route(int userChoice){
    if(userChoice == 1){
        GetFull();
    }
    else if(userChoice == 2){
        GetPartial();
    }
    else if(userChoice != 3){
        SayInvalid();
    }

}


//Pause Action
static void PauseAction(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}




//MakeFullTriangle
static void GetFull(){
    Random rnd = new Random();
    int rows = rnd.Next(3, 10);
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("O ");
            }
            
        Console.WriteLine();
    }
}        

//MakePartialTriangle 
static void GetPartial(){
    int numRows = new Random().Next(3, 10);
    for (int i = 1; i <= numRows; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (j == 1 || j == i || i == numRows)
            {
                System.Console.WriteLine("O ");
            }
            else
            {
                int number = new Random().Next(2);
                if (number == 0)
                {
                    Console.Write("O ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
        }
        Console.WriteLine();
    }
}


