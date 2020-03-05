using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BulletSpawn : MonoBehaviour
{
    private float x;
    [SerializeField] private Transform bulletsParentsTransform = default;

    [SerializeField] private GunSwap gunswap_ = default;
    // Start is called before the first frame update
    private void Awake()
    {
        
    
    }

    public void Update()
    {
        x+= Time.deltaTime*20;
    }

    public void SpawnBall()
    {
        if (gunswap_.RecoverGun().bullet.name == "Cartouche")
        {
            GameObject bullet_1 = Instantiate(gunswap_.RecoverGun().bullet.bullet_object, new Vector3(transform.position.x + 0.6f, transform.position.y, transform.position.z),
                transform.rotation, bulletsParentsTransform);
            GameObject bullet_2 = Instantiate(gunswap_.RecoverGun().bullet.bullet_object, new Vector3(transform.position.x - 0.6f, transform.position.y, transform.position.z),
                transform.rotation, bulletsParentsTransform);
            GameObject bullet_3 = Instantiate(gunswap_.RecoverGun().bullet.bullet_object, new Vector3(transform.position.x, transform.position.y + 0.6f, transform.position.z),
                transform.rotation, bulletsParentsTransform);
            GameObject bullet_4 = Instantiate(gunswap_.RecoverGun().bullet.bullet_object, new Vector3(transform.position.x, transform.position.y - 0.6f, transform.position.z),
                transform.rotation, bulletsParentsTransform);
            GameObject bullet_5 = Instantiate(gunswap_.RecoverGun().bullet.bullet_object, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.6f),
                transform.rotation, bulletsParentsTransform);
            GameObject bullet_6 = Instantiate(gunswap_.RecoverGun().bullet.bullet_object, new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.6f),
                transform.rotation, bulletsParentsTransform);
            

            bullet_1.GetComponent<Rigidbody>().AddForce(transform.forward * gunswap_.RecoverGun().bullet.spawningForce);
            bullet_2.GetComponent<Rigidbody>().AddForce(transform.forward * gunswap_.RecoverGun().bullet.spawningForce);
            bullet_3.GetComponent<Rigidbody>().AddForce(transform.forward * gunswap_.RecoverGun().bullet.spawningForce);
            bullet_4.GetComponent<Rigidbody>().AddForce(transform.forward * gunswap_.RecoverGun().bullet.spawningForce);
            bullet_5.GetComponent<Rigidbody>().AddForce(transform.forward * gunswap_.RecoverGun().bullet.spawningForce);
            bullet_6.GetComponent<Rigidbody>().AddForce(transform.forward * gunswap_.RecoverGun().bullet.spawningForce);
        }
        GameObject bullet_ = Instantiate(gunswap_.RecoverGun().bullet.bullet_object, transform.position, transform.rotation, bulletsParentsTransform);
        bullet_.GetComponent<Rigidbody>().AddForce(transform.forward * gunswap_.RecoverGun().bullet.spawningForce);
    }
}