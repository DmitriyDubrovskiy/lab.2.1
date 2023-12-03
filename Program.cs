class Program
{
    static void Main()
    {
        // Створення екземпляра класу Address та заповнення інформацією про адресу
        Address addressInstance = new Address(index: "12345", country: "Україна", city: "Київ", street: "Вулиця", house: "1", apartment: "2");

        // Виведення на екран значень полів, що описують адресу
        Console.WriteLine("Індекс: " + addressInstance.Index);
        Console.WriteLine("Країна: " + addressInstance.Country);
        Console.WriteLine("Місто: " + addressInstance.City);
        Console.WriteLine("Вулиця: " + addressInstance.Street);
        Console.WriteLine("Будинок: " + addressInstance.House);
        Console.WriteLine("Квартира: " + addressInstance.Apartment);
    }
}