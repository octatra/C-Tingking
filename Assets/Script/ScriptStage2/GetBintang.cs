using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBintang : MonoBehaviour
{
    public int Point;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<ButtonMove>().TakePoint(Point);
            Destroy(gameObject);
        }
    }
}
