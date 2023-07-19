using System;
using Core;
using NUnit.Framework;

namespace Tests.Editor
{
    public class LifeShould // LifeShouldDecreaseOnHit
    {
        private Life _life;

        [SetUp]
        public void SetUp()
        {
            _life = new Life(); // given
        }

        [Test]
        public void Heal()
        {
            //when - Act
            _life.Heal(11);

            //then - assert
            Assert.Greater(_life.CurrentValue, 10);
        }

        [Test]
        public void Decrease()
        {
            var before = _life.CurrentValue; //given
            
            _life.Damage(5); // Act
            
            Assert.Less( _life.CurrentValue, before); // then
        }

        [Test]
        public void MinValueIs0()
        {
            _life.Damage(Int32.MaxValue);// Act
            
            //then assert
            Assert.AreEqual(0,_life.CurrentValue);
        }

        [Test]
        public void LifeStartsAt100()
        {
            //then assert
            Assert.AreEqual(100,_life.CurrentValue);
        }

        [Test]
        public void MaxValueIs100()
        {
            _life.Heal(5000);
            
            Assert.AreEqual(100, _life.CurrentValue);
        }
    }
}