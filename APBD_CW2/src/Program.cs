using System;
using System.Linq;
using APBD_CW2.Enums;
using APBD_CW2.Models;
using APBD_CW2.Services;

namespace APBD_CW2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SYSTEM WYPOŻYCZALNI START ===");
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        string rootFilePath = Path.GetFullPath(Path.Combine(baseDir, @"../../../DataBase.json"));
        Console.WriteLine($"[Info] Plik bazy danych ustawiony na: {rootFilePath}");
        
        DataRepository repo = new DataRepository(rootFilePath);
        //LibraryData db = new LibraryData(); 
        LibraryData db = repo.Load();
        RentalService rentalService = new RentalService(db);

        /*Item macbook = new Laptop("MacBook Pro 16", 32, "M2 Max") { Id = 1 };
        Item projector = new Projector("Epson X", "1080p", 3000) { Id = 2 };
        Item camera = new Camera("Sony A7 III", 24, true) { Id = 3, Status = ItemStatus.Unavailable }; 
        db.Items.AddRange(new[] { macbook, projector, camera });

        User student = new Student("Jan", "Kowalski") { Id = 1 };
        User employee = new Employee("Anna", "Nowak") { Id = 2 };
        db.Users.AddRange(new[] { student, employee });*/
        
        
        
        Item macbook = db.Items.Where(i => i.Id == 1).FirstOrDefault() ?? new Laptop("MacBook Pro 16", 32, "M2 Max") { Id = 1 };
        Item projector = db.Items.Where(i => i.Id == 2).FirstOrDefault()?? new Projector("Epson X", "1080p", 3000) { Id = 2 };
        Item camera = db.Items.Where(i => i.Id == 2).FirstOrDefault() ?? new Camera("Sony A7 III", 24, true) { Id = 3, Status = ItemStatus.Unavailable };
        
        User student = db.Users.Where(i => i.Id == 1).FirstOrDefault() ?? new Student("Jan", "Kowalski") { Id = 1 };
        User employee = db.Users.Where(i => i.Id == 1).FirstOrDefault() ?? new Employee("Anna", "Nowak") { Id = 2 };
        
        Console.WriteLine("\n--- SCENARIUSZ TESTOWY ---");

        try 
        {
            rentalService.RentItem( student , macbook , daysToRent: 7);
            rentalService.RentItem(student , projector , daysToRent: 3);

            Console.WriteLine("\nPróba wypożyczenia ponad limit...");
            Item extraLaptop = db.Items.Where(i => i.Id == 2).FirstOrDefault() ?? new Laptop("Dell", 16, "i7") { Id = 4 };
            
            //db.Items.Add(extraLaptop);
            
            rentalService.RentItem(student, extraLaptop, daysToRent: 5); 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[BLOKADA] {ex.Message}");
        }

        try
        {
            Console.WriteLine("\nPróba wypożyczenia niedostępnego sprzętu...");
            rentalService.RentItem(employee, camera, daysToRent: 2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[BLOKADA] {ex.Message}");
        }

        Console.WriteLine("\nZwrot w terminie...");
        Rental activeRental = db.Rentals.First(r => r.ItemId == projector.Id);
        rentalService.ReturnItem(activeRental, projector);

        Console.WriteLine("\nZwrot opóźniony...");
        Rental lateRental = db.Rentals.First(r => r.ItemId == macbook.Id);
        rentalService.ReturnItem(lateRental, macbook, mockDate: lateRental.DueDate.AddDays(4));

        Console.WriteLine("\n=== RAPORT KOŃCOWY ===");
        Console.WriteLine($"Zarejestrowani użytkownicy: {db.Users.Count}");
        Console.WriteLine($"Zarejestrowany sprzęt: {db.Items.Count}");
        
        Console.WriteLine("\nSprzęt dostępny do wypożyczenia:");
        foreach (var item in db.Items.Where(i => i.Status == ItemStatus.Available))
        {
            Console.WriteLine($"- {item.Name} ({item.GetType().Name})");
        }
//
        //repo.Save(db);
        Console.WriteLine("\nStan systemu został pomyślnie zapisany do DataBase.json");
    }
}