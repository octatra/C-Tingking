using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private float startHealty;
    [SerializeField] private GameObject PanelKalah;

    [Header("iFrame")]
    [SerializeField] private float iFrameDuration;
    [SerializeField] private int number;
    public float CurrentHealty { get; private set; }
    private Animator Anim;
    private SpriteRenderer spriterend;
    // Start is called before the first frame update
    void Awake()
    {
        // Baru
        CurrentHealty = startHealty;
        Anim = GetComponent<Animator>();
        spriterend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float _damage)
    {
        CurrentHealty = Mathf.Clamp(CurrentHealty - _damage, 0, startHealty);

        if (CurrentHealty > 0)
        {
            StartCoroutine(Playerhit());
        }
        else
        {
/*            Anim.SetTrigger("Death");
            Debug.Log("Mati");*/
            StartCoroutine(Stopplayer());
        }
    }

    public IEnumerator Playerhit()
    {
        Physics2D.IgnoreLayerCollision(6, 7, true);
        for (int i = 0; i < number; i++)
        {
            spriterend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFrameDuration / (number * 2));
            spriterend.color = Color.white;
            yield return new WaitForSeconds(iFrameDuration / (number * 2));

        }
        Physics2D.IgnoreLayerCollision(6, 7, false);
    }

    //Baru
    public IEnumerator Stopplayer()
    {
        PanelKalah.SetActive(true);
        GetComponent<ButtonMove>().enabled = false;
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
