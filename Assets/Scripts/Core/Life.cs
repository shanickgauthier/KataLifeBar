using UnityEngine;

namespace Core
{
    public class Life
    {
        public int CurrentValue = 0;

        public void Heal(int value)
        {
            CurrentValue += value;
        }
    }
}