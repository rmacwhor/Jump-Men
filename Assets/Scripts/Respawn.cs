using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn: MonoBehaviour
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
            Transform spawn = other.GetComponent<PlayerManager>().spawn;
            GameObject playerCamera = other.GetComponent<PlayerManager>().playerCamera;
            other.transform.position = spawn.position;
            playerCamera.transform.position = new Vector3(spawn.position.x, spawn.position.y, playerCamera.transform.position.z);
            
        }
        else if (other.name == "Player2")
        {
            Transform spawn = other.GetComponent<PlayerManager>().spawn;
            GameObject playerCamera = other.GetComponent<PlayerManager>().playerCamera;
            other.transform.position = spawn.position;
            playerCamera.transform.position = new Vector3(spawn.position.x, spawn.position.y, playerCamera.transform.position.z);
        }
        Debug.Log("KillZone collided with " + other.name);
    }
}
