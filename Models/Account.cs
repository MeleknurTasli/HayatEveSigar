namespace HayatEveSigar.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string TCKN { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }
        public int HesCodeId { get; set; }
        public User User { get; set; }
        public HesCode HesCode { get; set; }
        public bool Visibility { get; set; }


        public Account()
        {

        }

        public Account(CreateAccountDTO createAccountDTO)
        {
            Visibility = true;
            PhoneNumber = createAccountDTO.PhoneNumber;
            TCKN = createAccountDTO.TCKN;
            Password = createAccountDTO.Password;
            UserID = createAccountDTO.UserID;
            HesCodeId = createAccountDTO.HesCodeId;
        }
    }
}