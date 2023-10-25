Random diceRoll = new Random();
int dice1 = 5;//diceRoll.Next(1,7);
int dice2 = 5;//diceRoll.Next(1,7);
int dice3 = 5;//diceRoll.Next(1,7);

int totalRollCount = dice1 + dice2 + dice3;
if (dice1 == dice2 || dice2 == dice3 || dice3 == dice1)
{
    if ((dice1 == dice2) && (dice2 ==  dice3))
    {
        Console.WriteLine("You are on a roll! Tripples it is!");
        totalRollCount += 6;
    }
    else
    {
        Console.WriteLine("What a roll! Doubles it is!");
        totalRollCount += 2;
    }
}
Console.WriteLine($"Dice 1: **{dice1}** + Dice 2: **{dice2}** + Dice 3: **{dice3}** = {totalRollCount}");

if (totalRollCount >= 15)
{
    Console.WriteLine("Congratulations! You won!");
}
else
{
    Console.WriteLine("Sorry! Try again next time!");
}