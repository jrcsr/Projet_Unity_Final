using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn_Zombie : MonoBehaviour
{
    public TextMeshProUGUI affichage = default;
    public TextMeshProUGUI affichage_vague = default;
    public TextMeshProUGUI affichage_rest_zombie = default;
    private int m_NombreZombie = 10;
    private Vector3 _pos = default;
    private GameObject[] _a = new GameObject[0];
    private float nbrVague = 0;
    private bool a = true;
    private int duree = 1;
    
    [SerializeField] private GameObject zombie = default;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Premiere_Vague());
        for (int i = 0; i < m_NombreZombie; i++)
        {
            _pos = new Vector3(Random.Range(-80, 80), 50f, Random.Range(-100, 80));
            Instantiate(zombie, _pos, Quaternion.Euler(0, -90, 0), transform.parent);
        }
    }
    
    void Update()
    {
        affichage_rest_zombie.text = _a.Length.ToString();
        affichage_vague.text = nbrVague.ToString();
        _a = GameObject.FindGameObjectsWithTag("Zombie");
        Debug.Log(_a.Length);
        if (_a.Length == 0 && a == true)
        {
            a = false;
            StartCoroutine(Attente_Vague());
        }
    }
    private IEnumerator Premiere_Vague()
    {
        nbrVague++;
        yield return  new WaitForSeconds(duree);
        affichage.text = "VAGUE N°" + nbrVague.ToString();
        yield return new WaitForSeconds(duree);
        affichage.text = "";
    }

    private IEnumerator Attente_Vague()
    {
        yield return new WaitForSeconds(duree);
        affichage.text = "!! FIN DE LA VAGUE !!";
        yield return new WaitForSeconds(duree);
        affichage.text = "";
        yield return new WaitForSeconds(duree);
        affichage.text = "!! VAGUE SUIVANTE !!";
        yield return new WaitForSeconds(1);
        affichage.text = "";
        m_NombreZombie *= 2;
        yield return new WaitForSeconds(15f);
        nbrVague++;
        yield return  new WaitForSeconds(duree);
        affichage.text = "VAGUE N°" + nbrVague.ToString();
        yield return new WaitForSeconds(duree);
        affichage.text = "";
        for (int i = 0; i < m_NombreZombie; i++)
        {
            _pos = new Vector3(Random.Range(-80, 80), 50f, Random.Range(-100, 80));
            Instantiate(zombie, _pos, Quaternion.Euler(0, -90, 0), transform.parent);
        }

        a = true;
    }
    
    public float getNbrVague()
    {
        return nbrVague;
    }
}
