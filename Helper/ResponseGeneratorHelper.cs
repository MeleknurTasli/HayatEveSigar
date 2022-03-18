using Microsoft.AspNetCore.Mvc;
namespace JobForStudents
{
    public class ResponseGeneratorHelper : ControllerBase
    {
        public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
        {
            switch (incomingResponse.ResponseCode)
            {
                case ResponseCodeEnum.Success:
                case ResponseCodeEnum.CreateDistrictOperationSuccess:



                    {
                        return Ok(incomingResponse);
                    }




                case ResponseCodeEnum.GetAllDistrictsOperationFail:


                    {
                        return NotFound(incomingResponse);
                    }




                case ResponseCodeEnum.CreateDistrictOperationFail:

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
}