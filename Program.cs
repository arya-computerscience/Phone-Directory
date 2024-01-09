

int Menu()
{
    Console.Clear();
    Console.WriteLine("1. Create the Directory");
    Console.WriteLine("2. Read and display the contents of the directory");
    Console.WriteLine("3. Find a phone number using name");
    Console.WriteLine("4. Add a new employee to the directory");
    Console.WriteLine("5. Exit Program");
   
     int option = Convert.ToInt32(Console.ReadLine());
    return option;
}

void CreateDirectory()
{
    Console.Clear();
    Console.WriteLine("Enter the name of the directory");
    string NameOfDirectory = Console.ReadLine();
    StreamWriter file = new StreamWriter(NameOfDirectory+".txt");
    file.Close();
    Console.Clear();
    Console.WriteLine("Directory: {0}.txt has been created",NameOfDirectory);
    Console.ReadLine();


}
void AddEmployee()
{
    Console.Clear();
    Console.WriteLine("Enter the name of the directory file");
    string DirectoryFileName = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter the name of the employee");
    string NameOfEmployee = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter the phone number of the employee");
    int PhoneNumber = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Enter the job title of the employee");
    string JobTitle = Console.ReadLine();
    Console.Clear();
    using (StreamWriter writer = File.AppendText(DirectoryFileName+".txt"))
    {
        writer.WriteLine(NameOfEmployee);
        writer.WriteLine(PhoneNumber);
        writer.WriteLine(JobTitle);
    }
    Console.ReadLine();

}
void ReadAndDisplay()
{
    Console.Clear();
    Console.WriteLine("Enter the name of the directory file");
    string ReadAndDisplayName = Console.ReadLine();
    StreamReader reader = new StreamReader(ReadAndDisplayName + ".txt");
    while (reader.EndOfStream == false)
    {
        string line = reader.ReadLine();
        Console.WriteLine(line);
    }
    Console.ReadLine();
   
}
void PhoneNumber()
{
    Console.Clear();
    Console.WriteLine("Enter the name of the directory file");
    string ReadAndDisplayName = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter the name of the employee");
    string EmployeeName = Console.ReadLine();
    StreamReader reader = new StreamReader(ReadAndDisplayName + ".txt");
    while (reader.EndOfStream == false)
    {
        string line = reader.ReadLine() ; 
        if (line == EmployeeName)
        {
            line = reader.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Phone Number: {0}",line);    
        }
    }

    Console.ReadLine();

}



int ReturnOption;

do
{
    ReturnOption = Menu();

    switch (ReturnOption)
    {
        case 1:
            {
             
                CreateDirectory();
                break;
            }
        case 2:
            {
                ReadAndDisplay();
                break;
            }
        case 3:
            {
                PhoneNumber();
                break;
            }
        case 4:
            {
                AddEmployee();
                break;
            }
        default:
            {
                
                break;
            }
    }
} while (ReturnOption != 5);