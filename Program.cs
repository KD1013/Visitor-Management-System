using System;
using System.Collections.Generic;

namespace VisitorManagementSystem
{
    public class Visitor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public List<VisitRecord> VisitHistory { get; set; } = new List<VisitRecord>();

        public Visitor(int id, string firstName, string lastName, string email, string phoneNumber, string homeAddress)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            HomeAddress = homeAddress;
        }
    }

    public class VisitRecord
    {
        public DateTime SignInTime { get; set; }
        public DateTime SignOutTime { get; set; }

        public VisitRecord(DateTime signInTime)
        {
            SignInTime = signInTime;
        }
    }

    class Program
    {
        static List<Visitor> visitors = new List<Visitor>();
        static int visitorIDCounter = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
            }
        }

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("     Visitor Management Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Add New Visitor");
            Console.WriteLine("2. Search Visitor");
            Console.WriteLine("3. Sign-In Visitor");
            Console.WriteLine("4. Sign-Out Visitor");
            Console.WriteLine("5. Text Message Sign-In/Sign-Out");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter your choice (1-6): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddNewVisitor();
                        break;
                    case 2:
                        SearchVisitor();
                        break;
                    case 3:
                        SignInVisitor();
                        break;
                    case 4:
                        SignOutVisitor();
                        break;
                    case 5:
                        TextMessageSignInSignOut();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Press any key to continue...");
                Console.ReadKey();
            }
        }

        public static void AddNewVisitor()
        {
            Console.WriteLine("\n--- Add New Visitor ---");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email Address: ");
            string email = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Home Address: ");
            string homeAddress = Console.ReadLine();

            var newVisitor = new Visitor(visitorIDCounter++, firstName, lastName, email, phoneNumber, homeAddress);
            visitors.Add(newVisitor);

            Console.WriteLine("Thank you! Visitor's information has been saved.");
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        public static void SearchVisitor()
        {
            Console.WriteLine("\n--- Search Visitor ---");
            Console.Write("Enter First Name, Last Name, or ID: ");
            string searchTerm = Console.ReadLine();

            Visitor foundVisitor = visitors.Find(v => v.FirstName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                        v.LastName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                        v.ID.ToString() == searchTerm);

            if (foundVisitor != null)
            {
                Console.WriteLine($"Visitor Found: {foundVisitor.FirstName} {foundVisitor.LastName}, Email: {foundVisitor.Email}, Phone: {foundVisitor.PhoneNumber}, Address: {foundVisitor.HomeAddress}");
                Console.WriteLine("Would you like to view their history (1) or edit their information (2)?");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice == 1)
                {
                    ViewVisitHistory(foundVisitor);
                }
                else if (choice == 2)
                {
                    EditVisitorInfo(foundVisitor);
                }
            }
            else
            {
                Console.WriteLine("Visitor not found.");
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        public static void ViewVisitHistory(Visitor visitor)
        {
            Console.WriteLine("\n--- Visit History ---");
            if (visitor.VisitHistory.Count == 0)
            {
                Console.WriteLine("No visit history found for this visitor.");
            }
            else
            {
                for (int i = 0; i < visitor.VisitHistory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Sign-In: {visitor.VisitHistory[i].SignInTime}, Sign-Out: {visitor.VisitHistory[i].SignOutTime}");
                }
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        public static void EditVisitorInfo(Visitor visitor)
        {
            Console.WriteLine("\n--- Edit Visitor Information ---");
            Console.WriteLine($"Current Information: {visitor.FirstName} {visitor.LastName}, Email: {visitor.Email}, Phone: {visitor.PhoneNumber}, Address: {visitor.HomeAddress}");

            Console.Write("Enter new First Name (leave blank to keep current): ");
            string firstName = Console.ReadLine();
            if (!string.IsNullOrEmpty(firstName)) visitor.FirstName = firstName;

            Console.Write("Enter new Last Name (leave blank to keep current): ");
            string lastName = Console.ReadLine();
            if (!string.IsNullOrEmpty(lastName)) visitor.LastName = lastName;

            Console.Write("Enter new Email Address (leave blank to keep current): ");
            string email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email)) visitor.Email = email;

            Console.Write("Enter new Phone Number (leave blank to keep current): ");
            string phoneNumber = Console.ReadLine();
            if (!string.IsNullOrEmpty(phoneNumber)) visitor.PhoneNumber = phoneNumber;

            Console.Write("Enter new Home Address (leave blank to keep current): ");
            string homeAddress = Console.ReadLine();
            if (!string.IsNullOrEmpty(homeAddress)) visitor.HomeAddress = homeAddress;

            Console.WriteLine("Visitor information updated.");
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        public static void SignInVisitor()
        {
            Console.WriteLine("\n--- Sign-In Visitor ---");
            Console.Write("Enter Visitor's First Name, Last Name, or ID: ");
            string searchTerm = Console.ReadLine();

            Visitor foundVisitor = visitors.Find(v => v.FirstName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                        v.LastName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                        v.ID.ToString() == searchTerm);

            if (foundVisitor != null)
            {
                Console.WriteLine($"Found Visitor: {foundVisitor.FirstName} {foundVisitor.LastName}");
                Console.Write("Confirm sign-in (yes/no): ");
                if (Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    foundVisitor.VisitHistory.Add(new VisitRecord(DateTime.Now));
                    Console.WriteLine("Visitor signed in successfully.");
                }
            }
            else
            {
                Console.WriteLine("Visitor not found. Please add the visitor first.");
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        public static void SignOutVisitor()
        {
            Console.WriteLine("\n--- Sign-Out Visitor ---");
            Console.Write("Enter Visitor's First Name, Last Name, or ID: ");
            string searchTerm = Console.ReadLine();

            Visitor foundVisitor = visitors.Find(v => v.FirstName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                        v.LastName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                        v.ID.ToString() == searchTerm);

            if (foundVisitor != null && foundVisitor.VisitHistory.Count > 0)
            {
                var lastVisit = foundVisitor.VisitHistory[^1];
                if (lastVisit.SignOutTime == default)
                {
                    lastVisit.SignOutTime = DateTime.Now;
                    Console.WriteLine("Visitor signed out successfully.");
                }
                else
                {
                    Console.WriteLine("Visitor is not currently signed in.");
                }
            }
            else
            {
                Console.WriteLine("Visitor not found or has no sign-in record.");
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

    }
}

