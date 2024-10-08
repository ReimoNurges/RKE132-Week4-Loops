Random rnd = new Random();
int myRandomNum;
int randomsum = 0;

for (int i = 0; i < 3; i++)
{
    
    int myRandomnNum = rnd.Next(0, 11);
    randomsum += myRandomnNum;
Console.WriteLine(myRandomnNum);


}
Console.WriteLine($"My rando sum {randomsum}");
