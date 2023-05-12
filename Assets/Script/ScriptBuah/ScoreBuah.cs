using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreBuah : MonoBehaviour
{
    private float pointBuah1;
    private float pointBuah2;
    public float MaxBuah1;
    public float MaxBuah2;
    public TextMeshProUGUI TextPoint;
    public TextMeshProUGUI TextPoint2;
    public GameObject Menang;
    public GameObject Kalah;
    public GameObject Spawner;
    public GameObject Joystick;

    //    [SerializeField] private Nyawa PointBintang;
    [SerializeField] private float PointBintang;
    [SerializeField] private GameObject[] bintang;

    // Update is called once per frame
    void Update()
    {
        TextPoint.text = pointBuah1.ToString();
        TextPoint2.text = pointBuah2.ToString();
        PointBintang = GetComponent<DarahGB>().CurrentNyawa;
        if (pointBuah1 >= MaxBuah1 && pointBuah2 >= MaxBuah2)
        {
            GetComponent<TimerBuah>().enabled = false;
            StartCoroutine(KondisiMenang());

        }
    }

    public void PointBuah1(float points)
    {
        pointBuah1 = pointBuah1 + points;

    }
    public void PointBuah2(float points)
    {
        pointBuah2 = pointBuah2 + points;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BSegar" && pointBuah1 < MaxBuah1)
        {
            PointBuah1(1);
        }
        if (collision.tag == "BSegar2" && pointBuah2 < MaxBuah2)
        {
            PointBuah2(1);
        }
    }

    public IEnumerator KondisiMenang()
    {
        Spawner.SetActive(false);
        yield return new WaitForSeconds(1);
        Menang.SetActive(true);
        Joystick.SetActive(false);
        if (PointBintang == 1)
        {
            yield return new WaitForSeconds(0.5f);
            bintang[0].SetActive(true);
        }
        else if (PointBintang == 2)
        {
            yield return new WaitForSeconds(0.5f);
            bintang[0].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            bintang[1].SetActive(true);
        }
        else if (PointBintang == 3)
        {
            yield return new WaitForSeconds(0.5f);
            bintang[0].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            bintang[1].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            bintang[2].SetActive(true);
        }
        yield return new WaitForSeconds(2);
    }
}
