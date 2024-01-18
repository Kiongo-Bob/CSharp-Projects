using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
string grade = "";

int[] sophia = {90, 86, 87, 98, 100};
int[] andrew = {92, 89, 81, 96, 90};
int[] emma = {90, 85, 87, 98, 68};
int[] logan = {90, 95, 87, 88, 96};

int[] students = {"Sophia", "Andrew", "Emma", "Logan"};
int indx = 0;
int studentSum = 0;
foreach(int student in students)
{
    indx++;
    Console.WriteLine($"Student {indx}: {student}");
    
    foreach(int score in student)
    {
        studentSum += score;
        Console.WriteLine(studentSum);
    }
}

// int sophiaSum = 0;
// decimal sophiaScore;

// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// foreach (string[] student in students)
// {
//     foreach(int score in student)
//         {
//             studentSum += score;
//             studentSum;
//         }
        
//         foreach(int score in andrew)
//         {
//         andrewSum += score;
//         }

//         foreach(int score in emma)
//         {
//             emmaSum += score;
//         }

//         foreach(int score in logan)
//         {
//             loganSum += score;
//         }
// }



// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine(score);

// if (score >= 97)
// {
//     grade = "A+";
// }
// else if ( score >= 93 || score <= 96)
// {
//     grade = "A";
// }
// else if ( score >= 90 || score <= 92)
// {
//     grade = "A-";
// }
// else if ( score >= 87 || score <= 89)
// {
//     grade = "B+";
// }
// else if ( score >= 83 || score <= 86)
// {
//     grade = "B";
// }
// else if ( score >= 80 || score <= 82)
// {
//     grade = "B-";
// }
// else if ( score >= 77 || score <= 79)
// {
//     grade = "C+";
// }
// else if ( score >= 73 || score <= 76)
// {
//     grade = "C";
// }
// else if ( score >= 70 || score <= 72)
// {
//     grade = "C-";
// }
// else if ( score >= 67 || score <= 69)
// {
//     grade = "D+";
// }
// else if ( score >= 63 || score <= 66)
// {
//     grade = "D";
// }
// else if ( score >= 60 || score <= 62)
// {
//     grade = "D-";
// }
// else if ( score <= 59)
// {
//     grade = "F";
// }


// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine($"Sophia:\t\t{score}\t{grade}");
// // Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// // Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// // Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
