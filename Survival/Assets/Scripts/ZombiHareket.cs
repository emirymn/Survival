using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiHareket : MonoBehaviour
{
    private GameObject player;
    public GameObject kalp;
    private int zombican = 3;
    private float mesafe;
    private oyunkontrol okont;
    private int zombidengelenpuan = 10;
    private AudioSource aSource;
    private bool zombieoluyor = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        okont = GameObject.Find("_Scripts").GetComponent<oyunkontrol>();
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;
        mesafe = Vector3.Distance(transform.position, player.transform.position);
        if(mesafe<6f)
        {
            if(!aSource.isPlaying)
            
            aSource.Play();
            if (!zombieoluyor)
            GetComponentInChildren<Animation>().Play("Zombie_Attack_01");

        }
        else
                {
            if (aSource.isPlaying)
                aSource.Stop();
        }
    }
    private void OnCollisionEnter(Collision c)
    {
      if(c.collider.gameObject.tag.Equals("mermi"))
        {
            Debug.Log("++");
            zombican -= 1;
            if (zombican==0)
            {
                zombieoluyor = true;
                okont.PuanArtir(zombidengelenpuan);
                Instantiate(kalp, transform.position, Quaternion.identity);
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject, 1.667f);
            }

        }
    }
}
