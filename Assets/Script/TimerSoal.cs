using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimerSoal : MonoBehaviour
{
    public TextMeshProUGUI TextTime;
    public float Waktu;
    public GameObject PanelKalah;
    public GameObject PanelMenang;

    float S;

    void Start()
    {
        Time.timeScale = 0;    
    }

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
