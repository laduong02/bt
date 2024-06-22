using System;

public class Program
{
    static void Main(string[] args)
    {
        ContactManager contactManager = new ContactManager();

        while (true)
        {
            Console.WriteLine("Contact Manager Menu:");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Find a contact by name");
            Console.WriteLine("3. Display contacts");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    contactManager.AddContact();
                    break;
                case 2:
                    contactManager.FindContact();
                    break;
                case 3:
                    contactManager.DisplayContacts();
                    break;
                case 4:
                    Console.WriteLine("Exiting Contact Manager...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}