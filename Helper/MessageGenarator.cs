
namespace JobForStudents
{




    public static class MessageGenarator
    {
        public static readonly Dictionary<ResponseCodeEnum, string> ResponseMessages
            = new Dictionary<ResponseCodeEnum, string>
        {
    { ResponseCodeEnum.Success, "Ok" },

    
    { ResponseCodeEnum.CreateAddressOperationSuccess, "Yeni Adres oluşturuldu" },
    { ResponseCodeEnum.CreateAddressOperationFail, "Yeni Adres oluşturulamadı" },



    };


        public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
        {
            return ResponseMessages[ResponseCode];
        }

    }
}