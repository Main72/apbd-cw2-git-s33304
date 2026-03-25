using APBD_CW2.Enums;
using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class RentItem :IRentItem
{
    public ItemStatus GetItemStatus(Item item)
    {
        return item.Status;
    }

    public void RentAnItem(Item item, User user)
    {
        throw new NotImplementedException();
    }

    public void ReturnAnItem(Item item, User user)
    {
        throw new NotImplementedException();
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
