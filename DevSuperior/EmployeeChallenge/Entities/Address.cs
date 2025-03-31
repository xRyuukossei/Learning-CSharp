﻿namespace EmployeeChallenge.Entities;
internal class Address
{
    public string Email { get; set; }
    public string Phone { get; set; }

    public Address() { }
    public Address(string email, string phone)
    {
        Email = email;
        Phone = phone;
    }
}
