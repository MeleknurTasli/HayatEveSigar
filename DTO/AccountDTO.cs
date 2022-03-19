public class AccountDTO
{

    public string PhoneNumber { get; set; }
    public int HesCodeId { get; set; }
    public bool Visibility {get;set;}
    public AccountDTO()
    {

    }
    public AccountDTO(Account account)
    {
        PhoneNumber = account.PhoneNumber;
        HesCodeId = account.HesCodeId;
        Visibility = account.Visibility;
    }
}
