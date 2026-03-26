s33304
University Equipment Rental System (APBD_CW2)
Project Overview
This is a C# console application designed to manage a university equipment rental system. The system allows for registering different types of hardware (Laptops, Projectors, Cameras), managing two types of users (Students and Employees), and handling the logic for rentals, returns, and late fee penalties.

UserType  |MaxItems  | Late Penalty
Student,  |     2    |   5 PLN / Day
Employee, |     5    |   5 PLN / Day

Design Decisions & Architecture
1. Separation of Concerns (High Cohesion)
I divided the project into three distinct layers to ensure that each class has one clear responsibility:

Models: Pure data containers (POCOs). They represent the "What" of the system. For example, the User class doesn't know how to save itself to JSON or how to calculate a rental limit.

Services: Contain the "How" (Business Logic).

RentalService handles the rules: "Can this person rent this item?" and "How much is the fine?".

DataRepository handles persistence: It is the only class that knows the file system exists.

Enums: Centralized state management for item availability.

2. Low Coupling
By using a DataRepository, the rest of the application is "decoupled" from the storage method. If we decided to switch from a JSON file to a SQL Database, we would only need to change the code in the repository; the RentalService and Program.cs would remain untouched.

3. SOLID Principles Applied
Single Responsibility Principle (SRP): Classes like Laptop only store laptop data. The logic for renting that laptop is moved to RentalService.

Open/Closed Principle: Thanks to Polymorphism and [JsonPolymorphic] attributes, the system is open for extension but closed for modification. We can add a new item type (e.g., Microphone) by creating a new class without changing the core rental logic.

Liskov Substitution Principle: All items inherit from the Item base class. The RentalService treats all items as Item objects, allowing any subtype to be rented without breaking the system.


