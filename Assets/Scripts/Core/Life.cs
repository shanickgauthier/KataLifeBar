using System;
using UnityEngine;

namespace Core
{
    public class Life
    {
        private const int InitialLife = 100;
        private const int MAX_LIFE = 100;
        private const int MIN_LIFE = 0;
        public int CurrentValue { get; private set; }

        public Life()
        {
            CurrentValue = InitialLife;
        }
        public void Heal(int value)
        {
            ModifyLife(value);
        }

        public void Damage(int value)
        {
            ModifyLife(-value);
        }
        private void ModifyLife(int value)
        {
            CurrentValue = Mathf.Clamp(CurrentValue + value, MIN_LIFE, MAX_LIFE);
        }
    }
}