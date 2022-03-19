using Microsoft.AspNetCore.Mvc;

    public class ResponseGeneratorHelper : ControllerBase
    {
        public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
        {
            switch (incomingResponse.ResponseCode)
            {
                case ResponseCodeEnum.Success:
                case ResponseCodeEnum.CreateCityOperationSuccess:
                case ResponseCodeEnum.DeleteCityOperationSuccess:
                case ResponseCodeEnum.GetAllCityOperationSuccess:



                    {
                        return Ok(incomingResponse);
                    }




                case ResponseCodeEnum.GetAllCityOperationFail:


                    {
                        return NotFound(incomingResponse);
                    }




                case ResponseCodeEnum.CreateCityOperationFail:
                case ResponseCodeEnum.CityEditOperationFail:
                case ResponseCodeEnum.DeleteCityOperationFail:

                    {
                        return NoContent();
                    }
                default:
                    {
                        return BadRequest(incomingResponse);
                    }
            }
        }
    }
