using APBD_CW2.Models;

namespace APBD_CW2.Services;

public static class IdGenerator
{
    public static int GetNextUserId(List<User> users)
    {
        if (users == null || !users.Any()) 
        {
            return 1;
        }
        
        return users.Max(u => u.Id) + 1;
    }

    public static int GetNextItemId(List<Item> items)
    {
        if (items == null || !items.Any()) 
        {
            return 1;
        }
        
        return items.Max(i => i.Id) + 1;
    }
}