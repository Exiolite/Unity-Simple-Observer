using Services.S_Money;
using UnityEngine;

public class MoneyTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            EMoney.AddMoney.Invoke(new Money(1000));
    }
}