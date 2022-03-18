
public class PatientDensity
{
    public int Id { get; set; }
    public int AddressID { get; set; }
    public Address Address {get; set;}
    public List<User>? Users {get; set;}
    
}