# University Equipment Rental System (APBD_CW2)
**Index:** s33304

## Project Overview
This is a C# console application designed to manage a university equipment rental system. The system allows for registering different types of hardware (Laptops, Projectors, Cameras), managing two types of users (Students and Employees), and handling the logic for rentals, returns, and late fee penalties.

## Business Rules

| User Type | Max Items | Late Penalty |
| :--- | :---: | :---: |
| **Student** | 2 | 5 PLN / Day |
| **Employee** | 5 | 5 PLN / Day |

---

## Warstwa Modeli (Folder Models)
Te klasy pełnią rolę kontenerów na dane (POCO) i nie zawierają logiki biznesowej:

* **User (Abstrakcyjna):** Klasa bazowa dla użytkowników. Definiuje wspólne pola (`Id`, `Imię`, `Nazwisko`) oraz abstrakcyjną właściwość `MaxRentCount`.
  * **Student:** Dziedziczy po `User`. Ustawia limit wypożyczeń na 2.
  * **Employee:** Dziedziczy po `User`. Ustawia limit wypożyczeń na 5.
* **Item (Abstrakcyjna):** Klasa bazowa dla sprzętu. Zawiera pola wspólne, takie jak `Id`, `Name` oraz `Status`.
  * **Laptop, Projector, Camera:** Konkretne implementacje sprzętu. Każda z nich posiada unikalne dla siebie pola (np. RAM dla laptopa, Jasność dla projektora).
* **Rental:** Reprezentuje fakt wypożyczenia. Przechowuje powiązania między `UserId` a `ItemId` oraz daty wypożyczenia i planowanego zwrotu.
* **LibraryData:** Główny obiekt stanu systemu. Przechowuje listy wszystkich użytkowników, przedmiotów i aktywnych/zakończonych wypożyczeń. Jest to obiekt, który podlega serializacji do JSON.

---

## Warstwa Serwisów (Folder Services)
Tu znajduje się logika "działania" aplikacji:

* **RentalService:** Serce systemu. Odpowiada za:
  * Sprawdzanie limitów użytkownika przed wypożyczeniem.
  * Weryfikację dostępności sprzętu.
  * Logikę zwrotów i naliczanie kar za spóźnienie.
* **DataRepository:** Odpowiada za trwałość danych (Persistence).
  * Implementuje odczyt i zapis obiektu `LibraryData` do pliku `DataBase.json`.
  * Izoluje resztę kodu od szczegółów technicznych biblioteki `System.Text.Json`.

---

## Inne
* **ItemStatus (Enum):** Definiuje możliwe stany sprzętu (`Available`, `Rented`, `Unavailable`). Dzięki temu unikamy błędów przy ręcznym wpisywaniu tekstów (tzw. "magic strings").
* **Program.cs:** Pełni rolę punktu wejścia (Entry Point). Inicjalizuje serwisy i przeprowadza scenariusz demonstracyjny wymagany w zadaniu.

---

## Design Principles

### Low Coupling
By using a `DataRepository`, the rest of the application is "decoupled" from the storage method. If we decided to switch from a JSON file to a SQL Database, we would only need to change the code in the repository; the `RentalService` and `Program.cs` would remain untouched.

### SOLID Principles Applied
* **Single Responsibility Principle (SRP):** Classes like `Laptop` only store laptop data. The logic for renting that laptop is moved to `RentalService`.
* **Open/Closed Principle:** Thanks to Polymorphism and `[JsonPolymorphic]` attributes, the system is open for extension but closed for modification. We can add a new item type (e.g., `Microphone`) by creating a new class without changing the core rental logic.
* **Liskov Substitution Principle:** All items inherit from the `Item` base class. The `RentalService` treats all items as `Item` objects, allowing any subtype to be rented without breaking the system.
