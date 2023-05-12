using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarahGB : MonoBehaviour
{
    [SerializeField] private float nyawaAwal;
    [SerializeField] private GameObject PanelKalah;

    public float CurrentNyawa { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        CurrentNyawa = nyawaAwal;

    }


    public void NyawaBerkurang(float Hit)
    {
        CurrentNyawa = Mathf.Clamp(CurrentNyawa - Hit, 0, nyawaAwal);

        if (CurrentNyawa == 0)
        {
            PanelKalah.SetActive(true);
            Time.timeScale = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BBusuk")
        {
            NyawaBerkurang(1);
        }
    }
}
