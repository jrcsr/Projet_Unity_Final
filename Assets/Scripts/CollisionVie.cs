using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionVie : MonoBehaviour
{ 
    private void OnCollisionEnter(UnityEngine.Collision other1)
    {
        if (other1.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}