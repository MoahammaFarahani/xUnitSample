
namespace TDD.Tests
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TDD.App;
    using Xunit;

    public class MathTests
    {
        private readonly IMath _math;
        private readonly IEnemyFactor _enemyFactor;
        private readonly INormalEnemy _normalEnemy;

        public MathTests()
        {
            _math = new TDD.App.Math();
            _enemyFactor = new TDD.App.EnemyFactor();
            _normalEnemy = new TDD.App.NormalEnemy();
        }
        [Fact]
        public void ShouldCreateNormalEnemy_SimpleExample()
        {
            object enemy = _enemyFactor.Create(false);
            Assert.IsType<NormalEnemy>(enemy);
        }
        [Fact]
        public void ShouldAssignableFromNormalEnemy_SimpleExample()
        {
            object enemy = _enemyFactor.Create(false);
            Assert.IsType(typeof(Enemy),enemy);
        }
        [Fact]
        public void ShouldAssignableFromNormalEnemy_Example()
        {
            object enemy = _enemyFactor.Create(false);
            Assert.IsAssignableFrom<Enemy>(enemy);
        }
        [Fact]
        public void ShouldCreateNormalEnemy_Cast()
        {
            object enemy = _enemyFactor.Create(false);
            var normalEnemy = Assert.IsAssignableFrom<INormalEnemy>(enemy);
            Assert.Equal(10, normalEnemy.Power());
        }
        [Fact]
        public  void ShouldCreateNormalEnemy_ExcludeDervedTypes()
        {
            object enemy = _enemyFactor.Create(false);
            Assert.IsAssignableFrom<Enemy>(enemy);
        }

        [Theory]
        [InlineData(18, 15, 3)]
        [InlineData(24, 32, 8)]
        [InlineData(-24, 32, 8)]
        [InlineData(-24, -32, 8)]
        [InlineData(32, 24, 8)]
        public void TestHappyPath(int a, int b, int expected)
        {
            var actual = _math.GetGcd(a, b);
            actual
                .Should()
                .Be(expected);
        }

        [Theory]
        [InlineData(4, 4)]
        [InlineData(3, 3)]
        public void TestGetListOfIntItems(int a, int expected)
        {
            var actualAll = _math.GetListOfIntItems(a);
            var actual = actualAll.Count;
            Assert.Equal(actual, expected);

        }
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void MyFirstTheory(int value)
        {
            Assert.True(_math.IsOdd(value));
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _math.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
        [Theory]
        [InlineData(4, 4)]
        [InlineData(3, 3)]
        public void FailingTest(int a, int expected)
        {
            var actualAll = _math.GetListOfIntItems(a);
            var actual = actualAll.Count;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void WhenSecondNumberIsZeroThenDivideByZeroExceptionsIsThrown()
        {
            Assert.Throws<DivideByZeroException>(() => _math.GetGcd(18, 0));
        }



    }
}
