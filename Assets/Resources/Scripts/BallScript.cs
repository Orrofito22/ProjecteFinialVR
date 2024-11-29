using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Temps en segons abans de destruir l'objecte
    public float destroyTime = 5f;

    void Start()
    {
        // Destrueix l'objecte després del temps especificat
        //Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
