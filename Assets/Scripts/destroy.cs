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
            Player1.transform.position = Spawn1.transform.position;
        else if (other.name == "Player2")
            Player2.transform.position = Spawn2.transform.position;

        Debug.Log("KillZone collided with " + other.name);
    }
}
