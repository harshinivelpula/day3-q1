

Random random = new Random();
int isemppr = random.Next(0, 2);
if (isemppr == 1)
{
    Console.WriteLine("Prsent");
    int Wageperhour = 20;
    int fulldayhour = 8;
    int dailywage = Wageperhour * fulldayhour;
    Console.WriteLine("Daily wage of the employee is = " + dailywage);
    Console.WriteLine("Enter 1 - Part time & 2- for full time employee");
    int choice = Convert.ToInt16(Console.ReadLine());
    int day_hr = 0;
     switch (choice)
    {
        case 1:
            day_hr = 4;
            break;
        case 2:
            day_hr = 8;
            break;
        default:
            day_hr = 0;
            break;
    }
}
else
{
    Console.WriteLine("Absent");
}