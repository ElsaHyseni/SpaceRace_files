using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 4.2f;
    public bool isGoingRight;
 
    void Update()
    {
        if (isGoingRight)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        else
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DestroyAsteroid")
        {
            Destroy(gameObject);
        }
    }
}
