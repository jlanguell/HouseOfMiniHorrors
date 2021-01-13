using UnityEngine;
using System.Collections;
using System;

public class Knife_Thrower : MonoBehaviour
{
    public int counter;
    public int knives;
    public GameObject knife;
    public string current_knife;

    // Use this for initialization
    void Awake()
    {
        //Cursor.visible = false;
        int knives = 3;
        
        int counter = 0;


    }

    void Update()
    {   
        
        if (Input.GetMouseButtonDown(0))
        {
            
            counter += 1;
            if (counter <= knives)
            {
                current_knife = String.Concat("Knife_", counter);
                knife = GameObject.Find(current_knife);
                

                //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 throwPosition;
                throwPosition.x = -1.35f;
                throwPosition.y = 2.1f;
                throwPosition.z = -2; 
                //mousePosition.z = -1;
                //knife.transform.position = mousePosition;
                
                knife.transform.position = throwPosition;
                if (GetComponent<Collider2D>().OverlapPoint(throwPosition))
                {
                    //do great stuff
                }
                else
                {
                    //display dead eric
                }
            }

        }
    }

    /*
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "dartboard")
        {
            //Set the parent of that object to the hierarchical platform
            collision.transform.parent = GameObject.Find("KnifeToss_Background").transform;
        }
    } */
}
