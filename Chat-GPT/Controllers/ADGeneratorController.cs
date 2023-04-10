using Chat_GPT.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chat_GPT.Controllers
{
    [Route("api/adgenerator/[action]")]
    [ApiController]
    public class ADGeneratorController : ControllerBase
    {
        private readonly IADProductService _adProduct;
        public ADGeneratorController(IADProductService adProduct)
        {
            _adProduct = adProduct;
        }

        [HttpPost]
        public async Task<ActionResult<ADProductResponseModel>> GenerateAD(CustomerRequestModel aDGenerateRequestModel)
        {
            try
            {

                var response = await _adProduct.GenerateAdContent(aDGenerateRequestModel);

                return response;
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }
    }
}
