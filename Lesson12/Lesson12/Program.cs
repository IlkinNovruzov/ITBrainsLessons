using System.Globalization;

namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine("------------------\n" +
                               "1.Add Medicine\n" +
                               "2.Show All Medicines\n" +
                               "3.Find Medicine By Name\n" +
                               "4.Sell Medicine\n" +
                               "5.Total Income\n" +
                               "6.Exit");
                Console.Write("Option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Pharmacy.AddMedicine();
                        break;
                    case 2:
                        Pharmacy.ShowAllMedicine();
                        break;
                    case 3:
                        Pharmacy.FindMedicineByName();
                        break;
                    case 4:
                        Pharmacy.SellMedicine();
                        break;
                    case 5:
                        Console.WriteLine(Pharmacy.totalIncome);
                        break;
                    case 6:
                        Console.WriteLine("Exited.");
                        b = false;
                        break;
                    default:
                        Console.WriteLine("There is not option.");
                        break;
                }
            }
        }
    }
    public class Medicine
    {
        public string name;
        public double price;
        public int count;
        public Medicine(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }
    }
    public class Pharmacy
    {
        public static double totalIncome = 0;
        public static List<Medicine> medicines = new List<Medicine>();
        public static void AddMedicine()
        {
            Console.Write("How many medicine do you add:");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine($"{i + 1}.Medicine");
                Console.Write("Enter medicine name:");
                string name = Console.ReadLine().Trim();
                Console.Write("Enter medicine price:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter medicine count:");
                int count = Convert.ToInt32(Console.ReadLine());
                bool b = false;
                Medicine m = new Medicine(name, price, count);
                for (int j = 0; j < Pharmacy.medicines.Count; j++)
                {
                    Medicine med = Pharmacy.medicines[j];
                    if (name.ToLower() == med.name.ToLower())
                    {
                        b = true;
                    }
                }
                if (b == false)
                {
                    Pharmacy.medicines.Add(m);
                    Console.WriteLine("Medicine added.");
                }
                else
                {
                    Console.WriteLine("There can be only one medicine with the same name.");
                }
            }
        }
        public static void ShowAllMedicine()
        {
            if (Pharmacy.medicines.Count == 0)
            {
                Console.WriteLine("There is not medicine.");
            }
            for (int i = 0; i < Pharmacy.medicines.Count; i++)
            {
                Medicine m = Pharmacy.medicines[i];
                Console.WriteLine($"{i + 1}.{m.name},{m.price},{m.count}");
            }

        }
        public static void FindMedicineByName()
        {
            Console.Write("Enter medicine name:");
            string name = Console.ReadLine();
            for (int i = 0; i < Pharmacy.medicines.Count; i++)
            {
                Medicine m = Pharmacy.medicines[i];
                if (m.name.ToLower().Contains(name))
                {
                    Console.WriteLine($"{i + 1}.{m.name},{m.price},{m.count}");
                }
            }

        }
        public static void SellMedicine()
        {
            Console.Write("Enter medicine name:");
            string name = Console.ReadLine().ToLower();
            Console.Write("Enter medicine count:");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Pharmacy.medicines.Count; i++)
            {
                Medicine m = Pharmacy.medicines[i];
                if (m.name.ToLower().Contains(name))
                {
                    if (m.count > count)
                    {
                        totalIncome += m.price * count;
                        m.count -= count;
                        Console.WriteLine($"{count} {m.name} were sold.");
                        Console.WriteLine($"Total Price:{m.price * count}");
                    }
                    else if (m.count == count)
                    {
                        Pharmacy.medicines.Remove(m);
                        Console.WriteLine("All the medicines were sold");
                        Console.WriteLine($"Total Price:{m.price * m.count}");
                    }
                    else
                    {
                        Console.WriteLine("Not enough medicine.");
                    }
                }
                else
                {
                    Console.WriteLine("Medicine not found.");
                }

            }
        }
    }
}