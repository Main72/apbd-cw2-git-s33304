using APBD_CW2.Services;

namespace APBD_CW2.Models;

public class LibraryData
{
    public List<User> Users { get; set; }
    public List<Item> Items { get; set; }

    public void CreateItem(Item item)
    {
        ItemService.AddItem(item,this.Items);
    }
    public void CreateUser(User user)
    {
        UserService.AddUser(user,this.Users);
    }
    
}