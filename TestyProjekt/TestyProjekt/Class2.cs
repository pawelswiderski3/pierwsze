using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestyProjekt
{
    public class MatmaTest
    {
        [Theory]
        [InlineData(10,20,30)]
        [InlineData(1,2,3)]
        [InlineData(4,8,12)]
        [InlineData(-1,-2,-3)]
        [InlineData(500,1000,1500)]
        [InlineData(455,200,655)]
        
        public void TheoryExample(double x, double y, double expected)
        {
            // arrange
            var math = new Matma();

            // act
            var result = math.Add(x, y);

            // assert
            Assert.Equal(expected, result);

        }

        [Fact]
        // test bad//
        public void Add_returns_sum_of_given_valuses2()
        {
            // arrange
            var math = new Matma();

            // act
            var result = math.Add(10, 20);

            // assert
            Assert.Equal(30, result);

        }

        [Fact]

        public void Substract_returns_sum_of_given_valuses()
        {

            //arrange
            var math = new Matma();

            //act
            var result = math.Substract(20, 10);

            //assert
            Assert.Equal(10, result);
        }


        [Fact]

        public void Multiply_returns_sum_of_given_values()
        {
            //arrange
            var math = new Matma();

            //act
            var result = math.Multiply(20, 10);

            //assert
            Assert.Equal(200, result);


        }

        [Fact]

        public void Divide_returns_sum_of_given_values()
        {
            //arrange
            var math = new Matma();

            //act
            var result = math.Multiply(20, 10);

            //assert
            Assert.Equal(200, result);
        }


    }

}

