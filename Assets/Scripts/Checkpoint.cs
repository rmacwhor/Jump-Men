using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player1")
        {
            Transform newSpawn = this.GetComponent<Transform>();
            other.GetComponent<PlayerManager>().spawn = newSpawn;
        }
        else if (other.name == "Player2")
        {
            Transform newSpawn = this.GetComponent<Transform>();
            other.GetComponent<PlayerManager>().spawn = newSpawn;
        }
    }
}
