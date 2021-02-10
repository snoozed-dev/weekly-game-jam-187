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
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;
    public GameObject Mark23;
    public GameObject Mark24;
    public GameObject Mark25;
    public GameObject Mark26;
    public GameObject Mark27;
    public GameObject Mark28;
    public GameObject Mark29;
    public GameObject Mark30;

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
        if (Marktracker == 6)
        {

            TheMarker.transform.position = Mark07.transform.position;
        }
        if (Marktracker == 7)
        {

            TheMarker.transform.position = Mark08.transform.position;
        }
        if (Marktracker == 8)
        {

            TheMarker.transform.position = Mark09.transform.position;
        }
        if (Marktracker == 9)
        {

            TheMarker.transform.position = Mark10.transform.position;
        }
        if (Marktracker == 10)
        {

            TheMarker.transform.position = Mark11.transform.position;
        }
        if (Marktracker == 11)
        {

            TheMarker.transform.position = Mark12.transform.position;
        }
        if (Marktracker == 12)
        {

            TheMarker.transform.position = Mark13.transform.position;
        }
        if (Marktracker == 13)
        {

            TheMarker.transform.position = Mark14.transform.position;
        }
        if (Marktracker == 14)
        {

            TheMarker.transform.position = Mark15.transform.position;
        }
        if (Marktracker == 15)
        {

            TheMarker.transform.position = Mark16.transform.position;
        }
        if (Marktracker == 16)
        {

            TheMarker.transform.position = Mark17.transform.position;
        }
        if (Marktracker == 17)
        {

            TheMarker.transform.position = Mark18.transform.position;
        }
        if (Marktracker == 18)
        {

            TheMarker.transform.position = Mark19.transform.position;
        }
        if (Marktracker == 19)
        {

            TheMarker.transform.position = Mark20.transform.position;
        }
        if (Marktracker == 20)
        {

            TheMarker.transform.position = Mark21.transform.position;
        }
        if (Marktracker == 21)
        {

            TheMarker.transform.position = Mark22.transform.position;
        }
        if (Marktracker == 22)
        {

            TheMarker.transform.position = Mark23.transform.position;
        }
        if (Marktracker == 23)
        {

            TheMarker.transform.position = Mark24.transform.position;
        }
        if (Marktracker == 24)
        {

            TheMarker.transform.position = Mark25.transform.position;
        }
        if (Marktracker == 25)
        {

            TheMarker.transform.position = Mark26.transform.position;
        }
        if (Marktracker == 26)
        {

            TheMarker.transform.position = Mark27.transform.position;
        }
        if (Marktracker == 27)
        {

            TheMarker.transform.position = Mark28.transform.position;
        }
        if (Marktracker == 28)
        {

            TheMarker.transform.position = Mark29.transform.position;
        }
        if (Marktracker == 29)
        {

            TheMarker.transform.position = Mark30.transform.position;
        }
    }

    private IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Autoincreible01")
        {
            this.GetComponent<SphereCollider>().enabled = false;
            Marktracker += 1;
            if (Marktracker == 30)
            {

                Marktracker = 0;

            }

            yield return new WaitForSeconds(1);
            this.GetComponent<SphereCollider>().enabled = true;


        }
    }





}
