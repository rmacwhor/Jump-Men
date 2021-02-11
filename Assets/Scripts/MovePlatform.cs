using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float distance = 10f;
    public float speed = 2f;
    public bool vertical = false;
    private Vector3 startPos;
    private Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        if (vertical)
        {
            nextPos = startPos;
            nextPos.y += distance;
        }
        else
        {
            nextPos = startPos;
            nextPos.x += distance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == nextPos)
        {
            Vector3 temp = startPos;
            startPos = nextPos;
            nextPos = temp;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
