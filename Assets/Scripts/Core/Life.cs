using System;
using UnityEngine;

namespace Core
{
    public class Life
    {
        private const int InitialLife = 100;
        public int CurrentValue { get; private set; }

        public Life()
        {
            CurrentValue = InitialLife;
        }
        public void Heal(int value)
        {
            CurrentValue += value;
        }

        public void Damage(int value)
        {
            CurrentValue -= value;
            CurrentValue = Mathf.Clamp(CurrentValue, 0, Int32.MaxValue);
        }
    }
}