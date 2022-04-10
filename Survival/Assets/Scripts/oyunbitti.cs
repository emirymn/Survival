using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunbitti : MonoBehaviour
{
    public Text puan;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        puan.text ="Puanýnýz :" +PlayerPrefs.GetInt("puan");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void yenidenoyna()
    {
        SceneManager.LoadScene("game");
    }
}
