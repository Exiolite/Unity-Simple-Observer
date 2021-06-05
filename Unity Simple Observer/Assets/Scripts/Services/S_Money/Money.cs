using System;
using UnityEngine;

namespace Services.S_Money
{
    [Serializable]
    public class Money
    {
        public int Value => _value;
        
        
        [SerializeField] private int _value;

        
        public Money() {}

        public Money(Money money) => _value = money.Value;

        public Money(int value)
        {
            if (value >= 0) _value = value;
        }
        
        
        public void Add(Money money)
        {
            _value += money.Value;
        }

        public bool TryRemove(Money money)
        {
            if (_value < money.Value) return false;
            _value -= money.Value;
            return true;
        }
    }
}