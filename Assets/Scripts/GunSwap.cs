using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunSwap : MonoBehaviour
{
    public GunList gunlist = default;
    public GameObject gunspawn = default;
    public TextMeshProUGUI display_gunname = default;
    private int a = 0;
    private void Start()
    {
        Instantiate(gunlist.liste[a].gun_object, gunspawn.transform.position, Quaternion.identity, transform);
        //display_gunname.text = gunlist.liste[a].name;
        StartCoroutine(Affichage_Nom());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            a++;
            if (a == 4)
            {
                a = 0;
            }
            Instantiate(gunlist.liste[a].gun_object, gunspawn.transform.position, transform.rotation, transform);
            //display_gunname.text = gunlist.liste[a].name;
            StartCoroutine(Affichage_Nom());
            Destroy(GameObject.FindGameObjectWithTag("Gun"));
            
        }
    }

    public Gun RecoverGun()
    {
        return gunlist.liste[a];
    }

    private IEnumerator Affichage_Nom()
    {
        display_gunname.text = gunlist.liste[a].name;
        yield return new WaitForSeconds(0.5f);
        display_gunname.text = "";

    }
}
