using System;
using System.Linq;
using APBD_CW2.Enums;
using APBD_CW2.Exeptions;
using APBD_CW2.Models;
using APBD_CW2.Services;

namespace APBD_CW2.Services;

public class RentalService
{
    private readonly LibraryData _db;
    private const decimal PenaltyPerDay = 5.0m; 

    public RentalService(LibraryData db)
    {
        _db = db;
    }

    public void RentItem(User user, Item item, int daysToRent)
    {
        if (item.Status != ItemStatus.Available)
            throw new ItemUnavalibleExeption(item);

        int activeRentals = _db.Rentals.Count(r => r.UserId == user.Id && r.ReturnDate == null);
        if (activeRentals >= user.MaxRentCount)
            throw new TooManyItemsRentedUserExeption(user);

        int newId = _db.Rentals.Any() ? _db.Rentals.Max(r => r.Id) + 1 : 1;
        Rental rental = new Rental(user.Id, item.Id, daysToRent) { Id = newId };
        
        item.Status = ItemStatus.Rented;
        _db.Rentals.Add(rental);
        
        Console.WriteLine($"[WYPOŻYCZONO] {user.FirstName} wypożyczył {item.Name} do {rental.DueDate.ToShortDateString()}.");
    }

    public void ReturnItem(Rental rental, Item item, DateTime? mockDate = null)
    {
        rental.ReturnDate = mockDate ?? DateTime.Now;
        item.Status = ItemStatus.Available;
        Console.WriteLine($"[ZWRÓCONO] Sprzęt {item.Name} został zwrócony.");

        if (rental.ReturnDate > rental.DueDate)
        {
            int daysLate = (rental.ReturnDate.Value - rental.DueDate).Days;
            decimal penalty = daysLate * PenaltyPerDay;
            Console.WriteLine($"[KARA] Opóźnienie: {daysLate} dni. Naliczono karę: {penalty} PLN."); 
        }
    }
}