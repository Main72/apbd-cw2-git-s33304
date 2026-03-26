using APBD_CW2.Enums;
using APBD_CW2.Exeptions;
using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class RentItem : IRentItem
{
    private readonly List<Item> _reservations = [];


    public void RentAnItem(Item item, User user , DateTime dayOfRent){

        if (item.Status != ItemStatus.Available)
        {
            throw new ItemUnavalibleExeption(item.Id);
        }
    }




    public void ReturnAnItem(Item item, User user)
    {
  
    }

    public List<Item> GetUserRents(User user)
    {
        throw new NotImplementedException();
    }

    public List<Item> GetItems()
    {
        throw new NotImplementedException();
    }
}

