using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class hareket : MonoBehaviour
{

    public Rigidbody2D top;
    public float ziplamaGucu;

    public Color turkuazRenk, sariRenk, morRenk, pembeRenk;
    
    public string mevcutRenk;
    public SpriteRenderer ressam;
    public Transform degistirici;
    public TextMeshProUGUI skorYazisi;
    public int skor;
    public Transform kontrol1, kontrol2, cember, kare,double_cember;
    public AudioSource ziplama;

    

    private void Start()
    {
        dondurme.donusHizi = 2;
        RastgeleRenk();
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            top.velocity = Vector2.up * ziplamaGucu;
            ziplama.Play();
        }
        skorYazisi.text = "Skor : "+skor.ToString();

    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.tag != mevcutRenk && temas.tag !="RenkDegistirici" && temas.tag != "Kontrol1" && temas.tag !="Kontrol2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (temas.tag == "RenkDegistirici")
        {
            skor += Random.Range(15, 31);
            degistirici.position = new Vector3(degistirici.position.x, degistirici.position.y + 6f, degistirici.position.z);
            RastgeleRenk();
            dondurme.donusHizi += 0.2f;
            

        }

        if(temas.tag == "Kontrol1")
        {
            kontrol1.position = new Vector3(kontrol1.position.x, kontrol1.position.y + 17f, kontrol1.position.z);
            cember.position = new Vector3(cember.position.x, cember.position.y + 17f, cember.position.z);
            kare.position = new Vector3(kare.position.x, kare.position.y + 17f, kare.position.z);
            double_cember.position = new Vector3(double_cember.position.x, double_cember.position.y + 17f, double_cember.position.z);
        }
        
    }


    void RastgeleRenk()
    {
        int rastgele = Random.Range(0, 4);

        switch (rastgele)
        {
            case 0:
                mevcutRenk = "Turkuaz";
                ressam.color = turkuazRenk;
                break;
            case 1:
                mevcutRenk = "Sari";
                ressam.color = sariRenk;
                break;
            case 2:
                mevcutRenk = "Mor";
                ressam.color = morRenk;
                break;
            case 3:
                mevcutRenk = "Pembe";
                ressam.color = pembeRenk;
                break;
        }
    }
}
