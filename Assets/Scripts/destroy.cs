using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player1;
    public GameObject Player2;
    public Transform Spawn1;
    public Transform Spawn2;
    public GameObject Camera1;
    public GameObject Camera2;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Player1.transform.position = Spawn1.transform.position;
            Camera1.transform.position = new Vector3(Spawn1.position.x, Spawn1.position.y, Camera1.transform.position.z);
            
        }
        else if (other.name == "Player2")
        {   
            Player2.transform.position = Spawn2.transform.position;
            Camera2.transform.position = new Vector3(Spawn2.position.x, Spawn2.position.y, Camera2.transform.position.z);
        }

        Debug.Log("KillZone collided with " + other.name);
    }
}
