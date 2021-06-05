using Services.S_Money;
using UnityEngine;
using UnityEngine.UI;

namespace Ui
{
    [RequireComponent(typeof(Text))]
    public class MoneyDisplayUi : MonoBehaviour
    {
        private Text _text;

        
        private void Awake() => _text = GetComponent<Text>();

        private void Start() => EMoney.OnMoneyChanged.AddListener(RequestMoney);

        private void OnEnable() => RequestMoney();

        
        private void RequestMoney() => EMoney.RequestMoney.Invoke(OnMoneyReceived);
        private void OnMoneyReceived(Money money)
        {
            _text.text = money.Value.ToString();
        }
    }
}