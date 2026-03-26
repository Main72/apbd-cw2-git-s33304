using System;

namespace APBD_CW2.Models;

public class Rental
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public int ItemId { get; set; }
    
    public DateTime RentalDate { get; set; }
    public DateTime DueDate { get; set; }
    
    public DateTime? ReturnDate { get; set; } 
    
    public Rental() { }

    public Rental(int userId, int itemId, int daysToRent)
    {
        UserId = userId;
        ItemId = itemId;
        RentalDate = DateTime.Now;
        DueDate = DateTime.Now.AddDays(daysToRent);
    }
}