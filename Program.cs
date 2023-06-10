// Brynn test question(s):

// 1. Have a user provide the size of a classroom via appropriate measurements, then calculate and display the area, perimeter, volume and surface area. If the area of the room (in sq.ft) is 250sq.ft or less, it's small. If it's less than 650sq.ft, it's medium. If it's 650sq.ft or more, it's large. 

//using System.Formats.Asn1;

//Console.WriteLine("Please provide the demension(s) of a classroom to calculate the corresponding area, perimeter, volume and surface area.");
//Console.WriteLine("___________________________________________________");
//Console.WriteLine("Please provide the length of the classroom in sq.ft: ");
//double roomLength = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Please provide the width of the classroom in sq.ft: ");
//double roomWidth = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Please provide the height of the classroom in sq.ft : ");
//double roomHeight = Convert.ToDouble(Console.ReadLine());

//double area = (roomLength * roomWidth);
//double perimeter = ((roomLength * roomWidth) * 2);
//double volume = (roomLength * roomWidth * roomHeight);
//double surArea = ((2 * (roomLength * roomHeight)) + (2 * (roomWidth * roomHeight)) + (2 * (roomWidth * roomHeight)));

//string sm = "This room is teeny tiny.";
//string md = "This room is pretty mid...";
//string xl = "Damn, that sure is a big ole' room.";

//Console.WriteLine();
//Console.WriteLine($"The area of the classroom is: {area} sq.ft");
//Console.WriteLine();
//Console.WriteLine($"The perimeter of the classroom is: {perimeter} sq.ft");
//Console.WriteLine();
//Console.WriteLine($"The volume of the classroom is: {volume} sq.ft");
//Console.WriteLine();

//if (surArea < 250)
//{
//    Console.WriteLine($"The surface area of the room is {surArea} sq.ft.");
//    Console.WriteLine($"{sm}");
//}
//else if ((surArea <= 650) && (surArea >= 250))
//{
//    Console.WriteLine($"The surface area of the room is {surArea} sq.ft.");
//    Console.WriteLine($"{md}");

//}
//else if (surArea > 650)
//{
//    Console.WriteLine($"The surface area of the room is {surArea} sq.ft.");
//    Console.WriteLine($"{xl}");
//}
//else
//{
//    Console.WriteLine("One of the values you have entered is invalid. Please try again.");
//}


// 2. Have a user provide an input between 1 - 100, validate the value and prompt the user to re-enter a value until they provide an accurate value. Check if the number is even or odd. Ask the user if they want to continue (yes or no), account for validating the response to continue.


//bool invalidInput = true;

//while (invalidInput)
//{
//    Console.WriteLine("Please enter a value between 1 - 100, to then determine if that number is either even or odd.");
//    Console.WriteLine("_______________________________________________");
//    string userInput = Console.ReadLine();

//    if (int.TryParse(userInput, out int validInput))
//    {
//        if ((validInput >= 1) && (validInput <= 100))
//        {
//            if ((validInput / 2) == (validInput * 0.5))
//            {
//                Console.WriteLine($"Your input was {validInput}.");
//                Console.WriteLine("You have entered an even number.");
//                Console.WriteLine("__________________________________");
//                Console.WriteLine("Would you like to enter a new number?");
//                string goAgain = Console.ReadLine().ToLower();
//                if ((goAgain == "yes") || (goAgain == "y"))
//                {
//                    invalidInput = true;
//                }
//                else
//                {
//                    invalidInput = false;
//                    Console.WriteLine("Goodbye.");
//                }
//            }
//            else
//            {
//                Console.WriteLine($"Your input was {validInput}");
//                Console.WriteLine("You have entered an odd number.");
//                Console.WriteLine("_________________________________");
//                Console.WriteLine("Would you like to enter a new number?");
//                string goAgain = Console.ReadLine().ToLower();
//                if ((goAgain == "yes") || (goAgain == "y"))
//                {
//                    invalidInput = true;
//                }
//                else
//                {
//                    invalidInput = false;
//                    Console.WriteLine("Goodbye.");
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("You have entered an invalid number. Please enter a number that is between 1 - 100.");
//            invalidInput = true;
//        }

//    }
//    else
//    {
//        Console.WriteLine("That is not a valid input. Please try again.");
//        invalidInput = true;
//    }
//}

// 3. Have a user provide a number greater than 0 but less than the max # an integer can be when cubed. Print out the number, the number squared, and the number cubed in a 'table'. Validate the provided input and prompt the user to re-enter the value until they provide an accurate value. Prompt the user to continue (yes or no) , account for validating the response to continue.

//Use bool logic to account for program needing to prompt user to either attempt entry of input again or end program once correct entry has been provided. 
bool invalidInput = true;
while (invalidInput)
{
    // Prompt the user to input a value within the specified threshhold.
    Console.WriteLine("Please enter a number greater than zero but less than the maximum number that can be stored within an integer data type, to then visually display a corresponding table of value(s):\n");

    // Store user input initially within a string data type.
    string userInput = Console.ReadLine();

    // TryParse the user input from a string data type into an integer data type.
    if (int.TryParse(userInput, out int vI))
    {
        // With "if" statement, account for user providing an entry that "is" parseable, but falls outside of the acceptable threshold that the program can withstand without breaking (not equal to or less than zero, but also not equal to or greater than 1290).
        if ((vI <= 0) || (vI >= 1290))
        {
            Console.WriteLine("You have entered a number beyond the maximum threshold an integer can be cubed. Please try again.");
            invalidInput = true;
        }
        // If user input has bypassed initial exception handling, then actually perform appropriate visual expression of user input as their "initial input," "input squared," and "input cubed."
        else
        {
            // Use variable "x" to account for starting point of visual table. If "x" is "less than" or "equal to" {vI}, increase incrementaly until reaching the parsed user input.
            for (int x = 1; x <= vI; x++)
            {
                // Create expressions to account for the "squared" and "cubed" section(s) of the visual table.
                int sI = (x * x);
                int cI = (x * x * x);
                // Use "**" to seperate because I'm stupid and think it's pretty.
                Console.WriteLine($"{x} ** {sI} ** {cI}");
            }
            // Prompt user to decide if they'd like to go again or end the program.
            Console.WriteLine("Would you like to continue? \n");
            // Force user input "ToLower" to account for unexpected capitalizations and/or lack thereof.
            string letsGo = Console.ReadLine().ToLower();
            if (letsGo == "y" || letsGo == "yes")
            {
                invalidInput = true;
            }
            // If the user input "anything" other than the expected entry to continue, end the program. 
            else
            {
                Console.WriteLine("Goodbye! :)");
                invalidInput = false;
            }
        }
    }
    // Account for a user input that is not a valid entry (example: ten, $, etc..)
    else
    {
        Console.WriteLine("You have entered a value that is not a valid entry. Please enter a valid integer input.");
        invalidInput = true;
    }
}



