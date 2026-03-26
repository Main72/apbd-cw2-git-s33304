using APBD_CW2.Services;

namespace APBD_CW2.Models;

public class LibraryData
{
    public List<User> Users { get; set; } = new();
    public List<Item> Items { get; set; } = new();
    public List<Rental> Rentals { get; set; } = new();
}