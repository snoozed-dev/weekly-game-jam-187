using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoIncreibleAI : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public int Marktracker;

  
    void Update()
    {
        if (Marktracker == 0)
        {

            TheMarker.transform.position = Mark01.transform.position;
        }

        if (Marktracker == 1)
        {

            TheMarker.transform.position = Mark02.transform.position;
        }
        if (Marktracker == 2)
        {

            TheMarker.transform.position = Mark03.transform.position;
        }

        if (Marktracker == 3)
        {

            TheMarker.transform.position = Mark04.transform.position;
        }

        if (Marktracker == 4)
        {

            TheMarker.transform.position = Mark05.transform.position;
        }
        if (Marktracker == 5)
        {

            TheMarker.transform.position = Mark06.transform.position;
        }
    }

    private IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Autoincreible01")
        {
            this.GetComponent<SphereCollider>().enabled = false;
            Marktracker += 1;
            if (Marktracker == 6)
            {

                Marktracker = 0;

            }

            yield return new WaitForSeconds(1);
            this.GetComponent<SphereCollider>().enabled = true;


        }
    } 
    
      
    


}
