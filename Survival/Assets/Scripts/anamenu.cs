using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{
    public GameObject intro;
    public GameObject intro2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(intro, 4f);
        Destroy(intro2, 4f);
        //StartCoroutine(Delay());
        //SceneManager.LoadScene("game");
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(4f);
    }
}
