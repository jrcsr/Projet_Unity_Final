using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_player : MonoBehaviour
{
    public GameObject zombie_spawner = default;
    private float detRange = 200f;
    public float speed = 0.2f;

    private GameObject plChar = default;
    private Vector3 monoTransform;

    private float x = default;
    public void Start () {
        plChar = GameObject.FindGameObjectWithTag("Player");
        monoTransform = transform.position;
        speed = (float) ((zombie_spawner.GetComponent<Spawn_Zombie>().getNbrVague() - 1) * 0.15 * speed + speed);
    }
 
    public void Update () {
        if((plChar.transform.position - transform.position).magnitude > 1 && (plChar.transform.position - transform.position).magnitude < detRange)
        {
            transform.LookAt(plChar.transform.position);
            transform.Translate(Vector3.forward * speed);
        }
    }
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Grenaille"))
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }

    private IEnumerator Attente()
    {
        yield return new WaitForSeconds(3f);
    }
}
