// Variables to initialize for the grading
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 }; 
int[] nicolasScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] zahirahScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] jeongScores = new int[] { 90, 95, 87, 88, 96, 96 };

string[] studentNames = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";



Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Nicolas")
        studentScores = nicolasScores;

    else if (currentStudent == "Zahirah")
        studentScores = zahirahScores;

    else if (currentStudent == "Jeong")
        studentScores = jeongScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

        if (currentStudentGrade >= 97)
            currentStudentLetterGrade = "A+";

        else if (currentStudentGrade >= 93)
            currentStudentLetterGrade = "A";

        else if (currentStudentGrade >= 90)
            currentStudentLetterGrade = "A-";

        else if (currentStudentGrade >= 87)
            currentStudentLetterGrade = "B+";

        else if (currentStudentGrade >= 83)
            currentStudentLetterGrade = "B";

        else if (currentStudentGrade >= 80)
            currentStudentLetterGrade = "B-";

        else if (currentStudentGrade >= 77)
            currentStudentLetterGrade = "C+";

        else if (currentStudentGrade >= 73)
            currentStudentLetterGrade = "C";

        else if (currentStudentGrade >= 70)
            currentStudentLetterGrade = "C-";

        else if (currentStudentGrade >= 67)
            currentStudentLetterGrade = "D+";

        else if (currentStudentGrade >= 63)
            currentStudentLetterGrade = "D";

        else if (currentStudentGrade >= 60)
            currentStudentLetterGrade = "D-";
        else
            currentStudentLetterGrade = "F";

        Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();