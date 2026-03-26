using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class ItemService
{
    public static void AddItem(Item newItem, List<Item> existingItems)
    {
        int nextId = existingItems.Any() ? existingItems.Max(i => i.Id) + 1 : 1;
        newItem.Id = nextId;
        
        existingItems.Add(newItem);

        Console.WriteLine($"[ItemService] Added {newItem.Name} with auto-generated ID: {newItem.Id}");
    }
}