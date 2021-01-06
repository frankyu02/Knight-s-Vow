using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looper : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject fireball;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("reloop", 1, 1.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reloop()
    {
        Spawn = Instantiate(fireball, transform.position, Quaternion.identity) as GameObject;
        

    }
}
