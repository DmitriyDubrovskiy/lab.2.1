using System;

class Address
{
    private string _index;
    private string _country;
    private string _city;
    private string _street;
    private string _house;
    private string _apartment;

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        _index = index;
        _country = country;
        _city = city;
        _street = street;
        _house = house;
        _apartment = apartment;
    }

    public string Index
    {
        get { return _index; }
    }

    public string Country
    {
        get { return _country; }
    }

    public string City
    {
        get { return _city; }
    }

    public string Street
    {
        get { return _street; }
    }

    public string House
    {
        get { return _house; }
    }

    public string Apartment
    {
        get { return _apartment; }
    }
}
