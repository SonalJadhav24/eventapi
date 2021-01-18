using System.Collections.Generic;
using EventsAPI.Services;

using System.Threading.Tasks;
using System.Web.Http.Cors;
using System.Web.Http;

namespace EventsAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        // GET api/<controller>

        private readonly ICustomerTransactionService _customerTransactionService;

        public CustomerController(ICustomerTransactionService CustomerTransactionService)
        {
            _customerTransactionService = CustomerTransactionService;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [ActionName("AllEventsForCutomerByID")]
        [Route("api/customer/AllEventsForCutomerByID/{CustomerID}")]
        public async Task <IHttpActionResult> GetAllEventsForCutomerByID(int CustomerID)
        {
            var cust_Transaction =   await _customerTransactionService.GetAsyncByID(CustomerID);
            return Ok(cust_Transaction);
        }

        [HttpGet]
        [ActionName("SelectEventsForCustomer")]
        public async Task<IHttpActionResult>  GetSelectEventsForCustomer([FromUri]int CustomerID, [FromUri] string EventType)
        {
            try
            {
                var cust_Transaction = await (_customerTransactionService.GetSelectedEventsData(CustomerID, EventType));
                return Ok(cust_Transaction);
            }
            catch (HttpResponseException ex)
            {
                return null;
            }
        }      
    }    
}