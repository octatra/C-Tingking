using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Buah;
    float time;
    float timer = 1;
    float RamdomX;
    int RandomBuah;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RamdomX = Random.Range(-8.94f, 9.45f);
        RandomBuah = Random.Range(0, Buah.Length);
        if (time <= 0)
        {
            Instantiate(Buah[RandomBuah], new Vector2(RamdomX, transform.position.y), Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
