using ConsoleApp22;

string? fullname;
do {
    Console.Write("Enter fullname: ");
    fullname = Console.ReadLine();
} while (!Student.CheckFullname(fullname));

string? groupNo;
do {
    Console.Write("Enter groupNo: ");
    groupNo = Console.ReadLine();
} while (!Student.CheckGroupNo(groupNo));

byte age;
do {
    Console.Write("Enter age: ");
} while (!byte.TryParse(Console.ReadLine(), out age) || age < 18 || age > 65);

Student student = new(fullname, groupNo, age);

student.Display();



