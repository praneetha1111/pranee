// See https://aka.ms/new-console-template for more information
string secretWord = "giraffe";
string guess = " ";
do
{
    Console.Write("Enter Guess: ");
    guess = Console.ReadLine();
 
}
while (guess != secretWord);
Console.WriteLine("YOU WIN!");

   
Console.ReadLine();