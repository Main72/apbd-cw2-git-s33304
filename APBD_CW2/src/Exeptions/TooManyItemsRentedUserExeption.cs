using APBD_CW2.Models;

namespace APBD_CW2.Exeptions;

public class TooManyItemsRentedUserExeption(User user): Exception($"Limit przekroczony: {user.FirstName} osiągnął limit {user.MaxRentCount} wypożyczeń.");
