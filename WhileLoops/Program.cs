
Random rnd = new Random();
int cpuRandom;
bool loopactive = true;
while(loopactive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("YAY YOU WIN!");
        loopactive = false;
        //break;
    }else
    {
        Console.WriteLine("Oops try again");
    }
}
Console.WriteLine("Have a nice day");