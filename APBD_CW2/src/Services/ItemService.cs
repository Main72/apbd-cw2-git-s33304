using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class ItemService
{
    private static int _id = 0;
    public int NextId(Item item)
    {
        return 1;
    }
    public int GetLastId()
    {
        return _id;
    }
    
}