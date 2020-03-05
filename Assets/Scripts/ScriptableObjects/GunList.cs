using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New List of Gun", menuName = "Gun List")]
public class GunList : ScriptableObject
{
    public List<Gun> liste = new List<Gun>();

}
