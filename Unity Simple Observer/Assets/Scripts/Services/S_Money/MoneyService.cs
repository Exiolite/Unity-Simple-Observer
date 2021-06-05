using System;
using UnityEngine;

namespace Services.S_Money
{
    public class MoneyService : MonoBehaviour
    {
        private Money _money = new Money();


        private void Start()
        {
            EMoney.AddMoney.AddListener(AddMoneyAndNotify);
            EMoney.TryRemoveMoney.AddListener(TryRemoveMoneyAndNotify);
            EMoney.RequestMoney.AddListener(CallbackMoney);
            EMoney.SetMoney.AddListener(SetMoneyAndNotify);
            
            EMoney.OnMoneyChanged.Invoke();
        }

        private void AddMoneyAndNotify(Money money)
        {
            _money.Add(money);
            
            EMoney.OnMoneyChanged.Invoke();
        }

        private void TryRemoveMoneyAndNotify(Money money, Action callback)
        {
            if (_money.TryRemove(money))
            {
                callback();
                EMoney.OnMoneyChanged.Invoke();
                return;
            }
            
            EMoney.OnNotEnoughMoney.Invoke();
        }

        private void CallbackMoney(Action<Money> callback)
        {
            callback(_money);
        }

        private void SetMoneyAndNotify(Money money)
        {
            _money = new Money(money);
            
            EMoney.OnMoneyChanged.Invoke();
        }
    }
}