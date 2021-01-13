using UnityEngine;
using System.Collections;
using System;

public class player_controller : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
        Cursor.visible = true;
        
    }

    void FixedUpdate()
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20)); // takes mouse input

        transform.position = new Vector3((worldPoint.x - 2.5f), (worldPoint.y + 2.5f), (transform.position.z)); // plants cursor in set xyz

       
    } 
    
}