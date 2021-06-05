using System;
using UnityEngine.Events;

namespace Services.S_Money
{
    public static class EMoney
    {
        public static readonly AddMoney AddMoney = new AddMoney();
        public static readonly TryRemoveMoney TryRemoveMoney = new TryRemoveMoney();
        
        public static readonly RequestMoney RequestMoney = new RequestMoney();
        public static readonly SetMoney SetMoney = new SetMoney();
        
        public static readonly OnMoneyChanged OnMoneyChanged = new OnMoneyChanged();
        public static readonly OnNotEnoughMoney OnNotEnoughMoney = new OnNotEnoughMoney();
    }
    public class AddMoney : UnityEvent <Money> {}
    public class TryRemoveMoney : UnityEvent <Money, Action> {}
    
    public class RequestMoney : UnityEvent <Action<Money>> {}
    public class SetMoney : UnityEvent <Money> {}
    
    public class OnMoneyChanged : UnityEvent {}
    public class OnNotEnoughMoney : UnityEvent {}
}