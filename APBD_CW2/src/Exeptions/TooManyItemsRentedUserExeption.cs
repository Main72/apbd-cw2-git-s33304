using APBD_CW2.Models;

namespace APBD_CW2.Exeptions;

public class TooManyItemsRentedUserExeption(User user): Exception($"{user.Type} with id {user.Id} has too many rented Items.");
