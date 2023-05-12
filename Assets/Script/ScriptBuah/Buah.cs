using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buah : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }

}
