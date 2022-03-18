public class Account
{
    public int Id { get; set; }
    public string PhoneNumber { get; set; }
    public string TCKN {get; set;}
    public string Password { get; set; }
    public int UserID { get; set; }
    public int HesCodeId { get; set; }
    public User User { get; set; }
    public HesCode HesCode {get; set;}

}