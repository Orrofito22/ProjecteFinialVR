using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaControllerScript : MonoBehaviour
{
    public ScoreManagerScript scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            scoreManager.AddScore(1); // Suma 1 punt
        }
    }
}
