using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimerBuah : MonoBehaviour
{
    public TextMeshProUGUI TextTime;
    public float Waktu;
    public GameObject PanelKalah;
    public GameObject PanelMenang;
    public GameObject Spawn;
    public GameObject Spawn2;

    float S;

    void Update()
    {
        S += Time.deltaTime;
        if (S >= 1)
        {
            Waktu--;
            S = 0;
        }

        if (Waktu <= 0)
        {
            Spawn.SetActive(false);
            Spawn2.SetActive(false);
            Time.timeScale = 0;
            PanelKalah.SetActive(true);
        }
        SetWaktu();
    }
    void SetWaktu()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTime.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

}
