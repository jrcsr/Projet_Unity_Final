using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Bullet", menuName = "Bullet")]
public class Bullet : ScriptableObject
{
    public GameObject bullet_object = default;
    public string name = default;
    public float spawningSpeed = default;
    public float spawningForce = default;

}