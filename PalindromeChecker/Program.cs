string word = "RACECA";

float length = word.Length;
float midpointFloat = (length)/2;
int midpointInt = word.Length/2;

int startCurrent = 0;
int lastCurrent = lengthInt;

if (midpointFloat > midpointInt)
{
    midpointInt += 1;
}

Console.WriteLine(midpointFloat+" "+ midpointInt);
