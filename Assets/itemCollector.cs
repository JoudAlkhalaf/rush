using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    int coins = 0;
    public Text coinText;
   [SerializeField] AudioSource collictionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinText.text = "coins :" + coins;
           collictionSound.Play();
        }
    }
}
