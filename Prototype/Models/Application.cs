namespace Prototype.Models;


/// <summary>
/// The Application class is a singleton that manages a list with every Organization instance.
/// It provides methods to add and remove organizations.
/// </summary>
public class Application
{
    private static readonly Lazy<Application> _instance = new Lazy<Application>(() => new Application());
    private List<Organization> _organizations;

    private Application()
    {
        this._organizations = new List<Organization>();
    }

    public static Application Instance => _instance.Value;

    public void AddOrganization(Organization organization)
    {
        if (organization != null && !this._organizations.Contains(organization))
        {
            this._organizations.Add(organization);
        }
    }

    public void RemoveOrganization(Organization organization)
    {
        if (organization != null && this._organizations.Contains(organization))
        {
            this._organizations.Remove(organization);
        }
    }

    public List<Organization> GetOrganizations()
    {
        return new List<Organization>(this._organizations);
    }
}