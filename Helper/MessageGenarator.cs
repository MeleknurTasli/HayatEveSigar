
namespace HayatEveSigar.Helper
{
    public static class MessageGenarator
    {
        public static readonly Dictionary<ResponseCodeEnum, string> ResponseMessages
            = new Dictionary<ResponseCodeEnum, string>
        {
        { ResponseCodeEnum.Success, "Ok" },


    { ResponseCodeEnum.CreateCityOperationSuccess, "Yeni il oluşturuldu" },
    { ResponseCodeEnum.CreateCityOperationFail, "Yeni il oluşturulamadı" },
    { ResponseCodeEnum.DeleteCityOperationFail, "İl Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteCityOperationSuccess, "İl Silindi" },
    { ResponseCodeEnum.GetAllCityOperationFail, "İl Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllCityOperationSuccess, "Tüm iller Listelendi" },
    { ResponseCodeEnum.CityEditOperationFail, "İl Düzenlenirken Hata meydana geldi" },

    };


        public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
        {
            return ResponseMessages[ResponseCode];
        }

    }
}