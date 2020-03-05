using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Faster : MonoBehaviour
{
    public GameObject zombie_spawner = default;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed =
            (float) ((zombie_spawner.GetComponent<Spawn_Zombie>().getNbrVague() - 1) * 0.3 * 20 + 20);
        gameObject.GetComponent<RigidbodyFirstPersonController>().movementSettings.BackwardSpeed =
            (float) ((zombie_spawner.GetComponent<Spawn_Zombie>().getNbrVague() - 1) * 0.3 * 20 + 20);
        gameObject.GetComponent<RigidbodyFirstPersonController>().movementSettings.StrafeSpeed =
            (float) ((zombie_spawner.GetComponent<Spawn_Zombie>().getNbrVague() - 1) * 0.3 * 20 + 20);
        gameObject.GetComponent<RigidbodyFirstPersonController>().movementSettings.JumpForce =
            (float) ((zombie_spawner.GetComponent<Spawn_Zombie>().getNbrVague() - 1) * 0.3 * 150 + 150);
    }
}
