namespace Prototype.Models;

public class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; } 
    public Gender Gender { get; set; }
    
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string JobTitle { get; set; }

    public int Id { get; set; }
    public string Password { get; set; }
}