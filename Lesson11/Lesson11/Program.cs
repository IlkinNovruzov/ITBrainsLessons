namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter name:");
                string name = Console.ReadLine();
                Console.Write("Enter email:");
                string email = Console.ReadLine();
                Console.Write("Enter password:");
                string password = Console.ReadLine();
                User user = new User(name, email, password);
                if (user.PasswordChecker(password))
                {
                    user.ShowInfo();
                    break;
                }
                else
                {
                    Console.WriteLine("- the password must have at least 8 characters\n" +
                        "- all letters in the password should not be uppercase\n" +
                        "- all letters in the password should not be lowercase");
                }
            }
        }
    }
    public abstract class Account
    {
        string name;
        string email;
        string password;

        public Account(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public abstract bool PasswordChecker(string password);
        public virtual void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Email:" + email);
        }
    }
    public class User : Account
    {

        public User(string name, string email, string pw) : base(name, email, pw) { }

        public override bool PasswordChecker(string password)
        {
            bool b1 = false, b2 = false;
            if (password.Length >= 8)
            {
                foreach (char item in password)
                {
                    if ((item >= 'A' && item <= 'Z'))
                    {
                        b1 = true;
                    }
                    if (item >= 'a' && item <= 'z')
                    {
                        b2 = true;
                    }
                    if (b1 && b2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}