using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCollions : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        score++;
        CoinText.text= "Score: "+score.ToString();
    }
}
