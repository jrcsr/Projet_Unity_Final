using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision_Grenaille : MonoBehaviour
{ 
    private void OnCollisionEnter(UnityEngine.Collision other1)
    {
        StartCoroutine(Attente(3f));
        Destroy(gameObject);
    }

    private IEnumerator Attente(float duree)
    {
        yield return new WaitForSeconds(duree);
    }
}