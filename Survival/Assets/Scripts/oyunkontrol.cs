using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public GameObject zombi;
    private float zamansayaci;
    private float olusumsureci = 10f;
    public Text puantext;
    private int puan;
    // Start is called before the first frame update
    void Start()
    {
        zamansayaci = olusumsureci;
    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        if (zamansayaci < 0)
        {
            Vector3 pos = new Vector3(Random.Range(230f,335f),24.14f, Random.Range(303f,197f));
            Instantiate(zombi, pos, Quaternion.identity);
            zamansayaci = olusumsureci;
        }
    }
    public void PuanArtir(int p)
    {
        puan += p;
        puantext.text =""+ puan;
    }
    public void Oyunbitti()
    {
        //Cursor.visible = true;
        PlayerPrefs.SetInt("puan", puan);
        SceneManager.LoadScene("oyunbitti");
    }
}
