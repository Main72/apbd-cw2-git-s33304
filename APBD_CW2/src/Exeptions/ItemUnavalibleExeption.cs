using APBD_CW2.Models;

namespace APBD_CW2.Exeptions;

public class ItemUnavalibleExeption(Item item): Exception($"Niedostępne: Sprzęt '{item.Name}' ma status {item.Status}.");
