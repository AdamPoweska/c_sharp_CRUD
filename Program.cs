using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static List<User> users = new List<User>();
    static int nextId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Dodaj użytkownika\n2. Pokaż użytkowników\n3. Edytuj użytkownika\n4. Usuń użytkownika\n5. Wyjście");
            Console.Write("Wybierz opcję: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateUser(); break;
                case "2": ReadUsers(); break;
                case "3": UpdateUser(); break;
                case "4": DeleteUser(); break;
                case "5": return;
                default: Console.WriteLine("Nieprawidłowy wybór."); break;
            }
        }
    }

    static void CreateUser()
    {
        Console.Write("Podaj imię: ");
        string name = Console.ReadLine();
        users.Add(new User { Id = nextId++, Name = name });
        Console.WriteLine("Użytkownik dodany.");
    }

    static void ReadUsers()
    {
        if (!users.Any())
        {
            Console.WriteLine("Brak użytkowników.");
            return;
        }

        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Imię: {user.Name}");
        }
    }

    static void UpdateUser()
    {
        Console.Write("Podaj ID użytkownika do edycji: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                Console.Write("Podaj nowe imię: ");
                user.Name = Console.ReadLine();
                Console.WriteLine("Użytkownik zaktualizowany.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono użytkownika.");
            }
        }
    }

    static void DeleteUser()
    {
        Console.Write("Podaj ID użytkownika do usunięcia: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("Użytkownik usunięty.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono użytkownika.");
            }
        }
    }
}
