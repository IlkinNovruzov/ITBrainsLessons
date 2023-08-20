using System.Collections;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            int loop = 0;

            while (loop == 0)
            {
                Console.Write("Username:");
                string usname = Console.ReadLine();
                Console.Write("Password:");
                string psword = Console.ReadLine();
                if (IsPasswordValid(psword) == true && IsUserNameValid(usname) == true)
                {
                    Account ac = new Account(usname, psword);
                    ht.Add(ac.No, ac.username);
                    ac.No++;
                    loop = 1;
                }
                else
                {
                    loop = 0;
                    Console.WriteLine("Try Again.");
                }
            }


            List<Student> students = new List<Student>();
            Student student = new Student("Ilkin Novruzov", "601.21", 19);
            students.Add(student);
            int option = 0;
            while (option < 3)
            {
                Console.WriteLine("1.Register Student\n" +
                                  "2.Show Student\n" +
                                  "3.Exit");
                Console.Write("Enter option:");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("How many student do you register:");
                        int count = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{(i + 1)}.Student");
                            Console.Write("Enter full name:");
                            string fullName = Console.ReadLine();
                            Console.Write("Enter group:");
                            string group = Console.ReadLine();
                            Console.Write("Enter age:");
                            int age = Convert.ToInt32(Console.ReadLine());

                            Student st = new Student(fullName, group, age);
                            students.Add(st);
                        }
                        Console.WriteLine("Registretion Completed.");
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case 2:
                        for (int i = 0; i < students.Count; i++)
                        {
                            Student st = students[i];
                            Console.WriteLine($"{i + 1}.Student = {st.fullName},{st.group},{st.age}");
                        }
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Exited.");
                        option = 3;
                        break;
                    default:
                        Console.WriteLine("Error! Try Again.");
                        break;
                }
            }

            Console.WriteLine("Birth Year:" + student.GetBirthYear());
            Console.WriteLine("Student Count:" + student.CountStudent(students));
        }
        public static bool IsUserNameValid(string username)
        {
            bool b = false;
            int c = 0;
            int upCase = 0, lowCase = 0, symbol = 0, digit = 0;
            for (int i = 0; i < username.Length; i++)
            {
                if (username[i] >= 'A' && username[i] <= 'Z')
                {
                    upCase++;
                }
                else if (username[i] >= 'a' && username[i] <= 'z')
                {
                    lowCase++;
                }
                else if (username[i] >= '0' && username[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    symbol++;
                }

            }
            if (symbol == 0)
            {
                b = true;

            }
            else
            {
                Console.WriteLine("Username can only be digits and letters.");
            }
            return b;

        }
        public static bool IsPasswordValid(string password)
        {
            bool a = false;
            int length = password.Length;
            int upCase = 0, lowCase = 0, symbol = 0, digit = 0;

            if (length >= 8 && length <= 25)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 'A' && password[i] <= 'Z')
                    {
                        upCase++;
                    }
                    else if (password[i] >= 'a' && password[i] <= 'z')
                    {
                        lowCase++;
                    }
                    else if (password[i] >= '0' && password[i] <= '9')
                    {
                        digit++;
                    }
                    else
                    {
                        symbol++;
                    }
                }
                if (upCase == 0 || symbol == 0 || digit == 0)
                {
                    Console.WriteLine("At least one symbol, 1 uppercase letter and at least one digit must be used in the password.");
                }
                else
                {
                    a = true;
                }
            }
            else
            {
                Console.WriteLine("Length of the password must be between 8 and 25 characters.");
            }
            return a;
        }
    }
    class Student
    {
        public string fullName;
        public string group;
        public int age;

        public Student(string fullName, string group, int age)
        {
            this.fullName = fullName;
            this.group = group;
            this.age = age;
        }
        public int GetBirthYear()
        {
            return DateTime.Now.Year - age;
        }
        public int CountStudent(List<Student> students)
        {
            return students.Count;
        }
    }
    class Account
    {
        public int No=1;
        public string username;
        public string password;
       
        public Account(string un, string pw)
        {
            this.username = un;
            this.password = pw;
        }

    }

}