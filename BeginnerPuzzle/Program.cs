

static void ExampleA()
{
    Console.WriteLine("\nExample A");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("\nWould you rather be a Parking Enforcement Officer or a Clown?: ");
    string? choice = Console.ReadLine();

    // String concatenation
    // Add the variable "choice" onto the end of the string
    Console.WriteLine("You chose: " + choice);
    Console.WriteLine("It was a trick question, they are BOTH clowns");
}


// Puzzle A
// Write a program that asks for your favourite color.
// It should output "Your favourite color is " and then their fav color
// Use String Interpolation to print the answer, not string concatenation as shown above.
// There are two types: $" blah blah blah {var}" and string.Format()

/*
static void PuzzleA()
{
    Console.WriteLine("\nPuzzle A");
    Console.WriteLine("~~~~~~~~~");

}
*/


static void ExampleB()
{
    Console.WriteLine("\nExample B");
    Console.WriteLine("~~~~~~~~~");

    string message = "I wish I had chainsaws for hands, or at least nuclear arms.";
    Console.WriteLine(message);
    Console.WriteLine("Converted to all lowercase: " + message.ToLower());
}


// Puzzle B
// Write a program that displays the message
// "I was too sick to do my homework."
// Then display this same message in all capitals (uppercase).
// Use string interpolation again, not concatenation as shown in Example B.

/*
static void PuzzleB()
{
    Console.WriteLine("\nPuzzle B");
    Console.WriteLine("~~~~~~~~~");

}
*/


static void ExampleC()
{
    Console.WriteLine("\nExample C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("What's your favourite food?: ");
    string? favFood = Console.ReadLine();

    Console.WriteLine("What's your favourite drink?: ");
    string? favDrink = Console.ReadLine();

    Console.WriteLine($"If I was to take you on a date, we would have {favFood} and {favDrink}.");
    Console.WriteLine($"But you are far too ugly for me to ask you on a date.");

}


// Puzzle C
// Ask the user to input a folder name
// Then ask the user to input a file name
// Display the file path "C:\{folderName}\{fileName}.txt" using the user's inputs
// You will need to learn how to escape the backslash characters or use verbatim strings.
/*
static void PuzzleC()
{
    Console.WriteLine("\nPuzzle C");
    Console.WriteLine("~~~~~~~~~");

}
*/



// Run the puzzles

    ExampleA();
    //PuzzleA();

    ExampleB();
    //PuzzleB();

    ExampleC();
    //PuzzleC();



Console.WriteLine("\n Press enter to exit the program...");
Console.ReadLine();                                         // Keeps the console app window open until you hit enter