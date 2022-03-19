namespace HayatEveSigar.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

        public async Task<ActionResult<AccountDTO>> CreateAccount(CreateAccountDTO accountDTO)
        {
           var account =  _accountRepository.CreateAccount(accountDTO);
           if(account != null)
           {
              return new AccountDTO(account);
           }
            throw new InvalidOperationException("Bu HES koduna ait bir hesap bulunmaktadır!");
        }

        public async Task<ActionResult<AccountDTO>>GetAccountByHesCodeId(int HesCodeId)
        {
          AccountDTO accountDTO = new AccountDTO(_accountRepository.GetAccountByHesCodeId(HesCodeId));
          if(accountDTO != null)
          {
              return accountDTO;
          }
          return new AccountDTO(null);
            

        }

        public async Task<ActionResult<AccountDTO>> GetAccountById(int ID)
        {
             AccountDTO accountDTO = new AccountDTO(_accountRepository.GetAccountById(ID));
          if(accountDTO != null)
          {
              return accountDTO;
          }
          return new AccountDTO(null);
            
        }

        public async Task<ActionResult<AccountDTO>>GetAccountByPasswordAndPhoneNumber(LoginDTO loginDTO)
        {
              AccountDTO accountDTO = new AccountDTO(_accountRepository.GetAccountByPasswordAndPhoneNumber(loginDTO));
          if(accountDTO != null)
          {
              return accountDTO;
          }
          return new AccountDTO(null);
            
        }

        public async Task<ActionResult<IEnumerable<AccountDTO>>> GetAllAccounts()
        {
            IEnumerable <AccountDTO> accountDTO = new AccountDTO(_accountRepository.GetAllAccounts());
          if(accountDTO != null)
          {
              return accountDTO;
          }
           return new List<AccountDTO>
           {
               new AccountDTO(null)
           };
        }

        public async Task<ActionResult<AccountDTO>> UpdateAccount(int Id)
        {
              AccountDTO accountDTO = new AccountDTO(_accountRepository.GetAccountById(Id));
          if(accountDTO != null)
          {
              return new AccountDTO(_accountRepository.UpdateAccount(Id));
          }
          return new AccountDTO(null);
            
           }
    }
}