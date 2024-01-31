using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RainfallApi.Model.Common;
using RainfallApi.Model.Contract;
using RainfallApi.Model.Exception;

namespace RainfallApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RainfallController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMapper _mapper;

        public RainfallController(IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _mapper = mapper;
        }

        /// <summary>
        ///  Get rainfall readings by station Id
        /// </summary>
        /// <param name="stationId">The id of reading station</param>
        /// 3680 - valid stationId
        [HttpGet("id/{stationId}/readings")]
        public async Task<ActionResult<RainfallContract>> GetRainfall(string stationId, [FromQuery] int count = 10)
        {
            try
            {
                if (stationId == null) return BadRequest();

                var res = await GetRainfallDataFromApi(stationId);
                if (res == null) return NotFound();

                var contractList = _mapper.Map<RainfallContract>(res);
                return Ok(contractList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse { Message = "Internal Server Error", Detail = new List<ErrorDetail> { new ErrorDetail { PropertyName = "ServerError", Message = ex.Message } } });
            }
        }

        private async Task<RainfallApiResponse?> GetRainfallDataFromApi(string stationId)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync($"http://environment.data.gov.uk/flood-monitoring/id/stations/{stationId}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<RainfallApiResponse?>();
            }

            return null;
        }
    }
}
