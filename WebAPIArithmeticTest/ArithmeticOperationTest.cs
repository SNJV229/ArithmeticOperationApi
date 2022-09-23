using ArithmeticOperationApi;
using ArithmeticOperationApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Math = ArithmeticOperationApi.Math;

namespace WebAPIArithmeticTest
{
    public class ArithmeticOperationTest
    {
        private readonly ValuesController _valuesController;
        private readonly Imath _math;
        public ArithmeticOperationTest()
        {
            _math = new Math();
            _valuesController = new ValuesController(_math);
        }
       
        [Fact]
        public void Test_for_addition()
        {
            double result = _math.sum(5, 6);

            Assert.Equal(11, result);
        }

        [Fact]
        public void Test_for_subtraction()
        {
            double result = _math.dif(8, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_for_multiplication()
        {
            double result = _math.mul(5, 6);

            Assert.Equal(30, result);
        }

        [Fact]
        public void Test_for_division()
        {
            double result = _math.div(15,5);

            Assert.Equal(3, result);
        }
    }
}