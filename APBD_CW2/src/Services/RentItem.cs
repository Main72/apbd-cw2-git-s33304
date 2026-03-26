using APBD_CW2.Enums;
using APBD_CW2.Exeptions;
using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class RentItem :IRentItem
{
    private readonly List<Item> _reservations = [];
    
    public void CreateReservation(User user, Item item, DateTime from)
    {
        if (item.Status != ItemStatus.Available)
        {
            throw new ItemUnavalibleExeption(item.ItemId);
        }

       
   
}
