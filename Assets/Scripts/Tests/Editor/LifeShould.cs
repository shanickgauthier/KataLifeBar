using Core;
using NUnit.Framework;

namespace Tests.Editor
{
    public class LifeShould // LifeShouldDecreaseOnHit
    {
        [Test]
        public void Heal()
        {
            //given - Arrange
            var life = new Life();

            //when - Act
            life.Heal(11);
            
            //then - assert
            Assert.Greater(life.CurrentValue, 10);
            
        }
        
    }
}