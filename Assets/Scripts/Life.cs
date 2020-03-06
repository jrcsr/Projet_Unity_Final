using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    private int PDV = 100;
    public TextMeshProUGUI displayPDV = default;
    // Start is called before the first frame update
    
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Zombie"))
        {
            PDV -= 2;
        }

        if (other.gameObject.CompareTag("Life"))
        {
            PDV += 5;
        }
    }

    private void Update()
    {
        displayPDV.text = PDV.ToString();
        if (PDV <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
