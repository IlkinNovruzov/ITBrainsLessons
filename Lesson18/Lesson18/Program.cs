using System.Configuration;

namespace Lesson18
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Account());
        }
    }
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
    public class UserMethods
    {
        public const string myDB = @"C:\Users\ilkin\OneDrive\Masaüstü\Mydatabase";

        public static void Registration(string username, string password)
        {
            var user=new User(username,password);
            var file = Path.Combine(myDB, user.username + ".txt");
            if (File.Exists(file))
            {
                MessageBox.Show("This user has already been registered.");
            }
            else
            {
                var contentText = $"Username:{user.username}\nPassword:{user.password}";
                File.WriteAllText(file, contentText);
                MessageBox.Show("Registration is succesfully!");
            }
        }
        public static List<User> GetUsers()
        {
            var users = new List<User>();
            var directory = new DirectoryInfo(myDB);
            var files = directory.GetFiles();
            foreach (var file in files)
            {
                var fileLines = File.ReadAllLines(file.FullName);
                string username = fileLines[0].Split(':')[1].Trim();
                string password = fileLines[1].Split(':')[1].Trim();
                users.Add(new User(username,password));
            }
            return users;
        }
        public static void Login(string username,string password)
        {
            var users = UserMethods.GetUsers();
            foreach (var item in users)
            {
                if (item.username ==username && item.password == password)
                {
                    MessageBox.Show("Succesfully.");
                }
                else
                {
                    MessageBox.Show("UnSuccesfully.");
                }
            }
        }
    }
}