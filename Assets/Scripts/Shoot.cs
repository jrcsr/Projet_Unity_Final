using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Shoot : MonoBehaviour
{
    [SerializeField] private BulletSpawn ballSpawner;
    public GunSwap gunswap_ = default;
    private bool b = true;
    [SerializeField] private TextMeshProUGUI distanceText = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gunswap_.RecoverGun().name == "Lance-grenade")
        {
            if (b == true)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    ballSpawner.SpawnBall();
                    StartCoroutine(Attente(2f));
                }
            }
        }
        else if (gunswap_.RecoverGun().name == "Mitraillette")
        {
            if (Input.GetButton("Fire1"))
            {
                
                ballSpawner.SpawnBall();
                StartCoroutine(Attente(1f));
                
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                
                ballSpawner.SpawnBall();
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                Debug.Log("Did Hit");
                Debug.Log("Distance objet :" + hit.distance);
                distanceText.text = hit.distance.ToString();
            }
        }
    }

    private IEnumerator Attente(float duree)
    {
        b = false;
        yield return new WaitForSeconds(duree);
        b = true;
    }
}
