namespace Prototype.Models;

public class Event
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }

    public List<Person> EventOwners { get; set; }
    public List<Person> EventMembers { get; set; }

    public Event(string name, Person owner)
    {
        this.Name = name;

        this.EventOwners = new List<Person> {owner};
        this.EventMembers = new List<Person>();
    }
}