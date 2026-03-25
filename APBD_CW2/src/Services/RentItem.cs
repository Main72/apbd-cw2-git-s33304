using APBD_CW2.Enums;
using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class RentItem
{
    public ItemStatus GetItemStatus(Item item)
    {
        return item.Status;
    }
  
}
