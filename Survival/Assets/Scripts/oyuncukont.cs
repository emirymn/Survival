using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyuncukont : MonoBehaviour
{
    public AudioClip atisSesi, olmesesi, canalmasesi, yaralanmasesi;
    public Transform mermipos;
    public GameObject mermi;
    public GameObject patlama;
    public Image canImaji;
    private float canDegeri = 100f;
    private ZombiHareket zhareket;
    public oyunkontrol okontrol;
    private AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        // zhareket = GameObject.Find("Zombie_01").GetComponent<ZombiHareket>();
        aSource = GetComponent<AudioSource>();
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            aSource.PlayOneShot(atisSesi,1f);
            GameObject go = Instantiate(mermi, mermipos.position, mermipos.rotation) as GameObject;
            GameObject goPatlama = Instantiate(patlama, mermipos.position, mermipos.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = mermipos.transform.forward * 50f;
            Destroy(go.gameObject, 2f);
            Destroy(goPatlama.gameObject, 2f);
            
        }


    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("zombi"))
        {
            aSource.PlayOneShot(yaralanmasesi, 1f);
            Debug.Log("zombisal");
            canDegeri -= 10f;
            float x = canDegeri / 100f;
            canImaji.fillAmount = x;
            canImaji.color = Color.Lerp(Color.red, Color.green,x);
            if(canDegeri<=0)
            {
                aSource.PlayOneShot(olmesesi, 1f);
                okontrol.Oyunbitti();
            }
        }
    }
    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag.Equals("kalp"))
        {
            aSource.PlayOneShot(canalmasesi, 1f);
            if (canDegeri<100f)
            { }
            canDegeri += 10f;
            float x = canDegeri / 100f;
            canImaji.fillAmount = x;
            canImaji.color = Color.Lerp(Color.red, Color.green, x);
           Destroy(c.gameObject);
        }
    }
    }

      

