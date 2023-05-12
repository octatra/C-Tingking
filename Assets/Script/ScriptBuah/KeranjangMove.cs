using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeranjangMove : MonoBehaviour
{
    public float SpeedKeranjang;
    Rigidbody2D rb;

    public GameObject Spawn;
    public GameObject Info;
    public GameObject Joystick;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float Horiz = SimpleInput.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Horiz * SpeedKeranjang, rb.velocity.y);
    }

    public void StartSpanw()
    {
        Spawn.SetActive(true);
        Info.SetActive(false);
        Joystick.SetActive(true);
    }
}
