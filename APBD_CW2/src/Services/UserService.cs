using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class UserService
{
    public static void AddUser(User newUser, List<User> existingUsers)
    {
        int nextId = existingUsers.Any() ? existingUsers.Max(u => u.Id) + 1 : 1;
        newUser.Id = nextId;
        
        existingUsers.Add(newUser);

        Console.WriteLine($"[UserService] Added {newUser.FirstName} {newUser.LastName} with auto-generated ID: {newUser.Id}");
    }
}