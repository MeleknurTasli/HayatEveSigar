public interface IAccountService
{
    public Task<AccountDTO> GetAccountById(int ID);
    public Task<AccountDTO> GetAccountByHesCodeId(int HesCodeId);
    public Task<AccountDTO> GetAccountByPasswordAndPhoneNumber(LoginDTO loginDTO);
    public Task<AccountDTO> UpdateAccount(int Id);
    public Task<AccountDTO> CreateAccount(CreateAccountDTO accountDTO);
    public Task<IEnumerable<AccountDTO>> GetAllAccounts(CreateAccountDTO accountDTO);
}