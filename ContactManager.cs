using System;
using System.Collections;

public class ContactManager
{
    private Hashtable contacts;

    public ContactManager()
    {
        contacts = new Hashtable();
    }

    public void AddContact()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();

        Contact contact = new Contact(name, phoneNumber);
        contacts.Add(name, contact);

        Console.WriteLine("Contact added successfully.");
    }

    public void FindContact()
    {
        Console.Write("Enter name to search: ");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Contact contact = (Contact)contacts[name];
            Console.WriteLine($"Phone number: {contact.PhoneNumber}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Address Book:");
        Console.WriteLine("------------");

        foreach (DictionaryEntry entry in contacts)
        {
            Contact contact = (Contact)entry.Value;
            Console.WriteLine($"Name: {contact.Name} | Phone: {contact.PhoneNumber}");
        }

        Console.WriteLine("------------");
    }
}