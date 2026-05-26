using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public TextMeshProUGUI coinText;

    int coins = 0;

    void Awake()
    {
        instance = this;
    }

    public void AddCoin()
    {
        coins++;

        coinText.text = "Monedas: " + coins;
    }
}