// MIS 3033
// Task 2

double totalgrade = 0.0;
string mesg = "";
int numofexams = 3;
for (int i = 0; i <numofexams; i++)
{
    mesg = string.Format("Please input exam {0}:", i + 1);
    Console.Write(mesg);
    string grade = Console.ReadLine();
    double examgrade = Convert.ToDouble(grade);
    totalgrade = totalgrade + examgrade;
}

double avrggrade = totalgrade / numofexams;
double avrggradepercent = avrggrade / 100;
mesg = String.Format("The final grade percentage is {0:P2}",avrggradepercent);
Console.WriteLine(mesg);
