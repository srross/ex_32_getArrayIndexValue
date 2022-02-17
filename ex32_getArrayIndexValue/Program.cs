/* IN PROCESS - NEEDS MORE WORK
 * 
 * Exercise 32 - Description Create an array of size 5
     * and fill it with the following numbers: 2, 8, 0, 24, 51. 
     * Prompt the user to enter a number. 
     * If the number is in the array, display the index at which it is located.
     */

var yn = "y";

int[] myArray = new int[5] { 2, 8, 0, 24, 51 };

while (yn == "y")
{
    Console.Write("Please enter a number: ");

    var num = 0;

    var isValidNum = int.TryParse(Console.ReadLine(), out num);

    if (isValidNum && myArray.Contains(num))
    {


    }
    else
    {
        Console.WriteLine($"Sorry, {num} can not be found in my array");
    }

    Console.WriteLine("Would you like to continue (y/n)? ");
    yn = Console.ReadLine();

}


Console.WriteLine("Bye-bye!");

//try Array.Clear - clears the values but not the elements.
