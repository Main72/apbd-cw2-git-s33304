using APBD_CW2.Models;

namespace APBD_CW2.Services;

public interface IRentItem
{
    public void RentAnItem(Item item,User user , DateTime dayOfRent);
    public void ReturnAnItem(Item item, User user);
    public List<Item> GetUserRents(User user);
    public List<Item> GetItems();
}