namespace APBD_CW2.Exeptions;

public class ItemUnavalibleExeption(int itemId): Exception($"Item with id {itemId} is not available.");
