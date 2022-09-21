using ArithmeticOperationApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ArithmeticOperationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Imath _math;

        public ValuesController(Imath math)
        {
            _math = math;
        }

        //public Imath math { get; }

        [HttpGet]
        [Route("Addition")]
        public ActionResult<double> additon(double a, double b)
        {
            double result = _math.sum(a, b);
            return result;
        }

        [HttpGet]
        [Route("Difference")]
        public ActionResult<double> subtraction(double a, double b)
        {            double result = _math.dif(a, b);
            return result;
        }

        [HttpGet]
        [Route("Multiplication")]
        public ActionResult<double> multiplication(double a, double b)
        {
            double result = _math.mul(a, b);
            return result;
        }

        [HttpGet]
        [Route("Division")]
        public ActionResult<double> division(double a, double b)
        {
            double result = _math.div(a, b);
            return result;
        }

    }
}
