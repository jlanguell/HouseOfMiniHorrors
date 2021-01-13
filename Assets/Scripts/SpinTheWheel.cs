using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpinTheWheel : MonoBehaviour
{
    Transform trans;

    void Awake()
    {
        trans = GetComponent<Transform>(); //return a component to trans:

        Cursor.lockState = CursorLockMode.Locked; // locks cursor
        
    }

    void Update() //every frame...
    {
        //import static variables to increase speed if targets hit/check on eric
        int num = KnifeRotation.numCorrect;
        bool alive = KnifeRotation.alive;

        //create vectors to rotate dartboard and axis to rotate dartboard around
        Vector3 point = new Vector3(0, 0, 0);
        Vector3 axis = new Vector3(0, 0, -1);

        // if eric dies, slow down wheel   !!!Need to add rect w text "YOU LOSE"!!!
        if (alive == false)
        {
            transform.RotateAround(point, axis, Time.deltaTime * 20);
        }
        
        //elseif, elseif, else statement to increase rotation speed
        else if (num == 0)
        {           
            transform.RotateAround(point, axis, Time.deltaTime * 100);
            
        }
        else if (num == 1)
        {
            transform.RotateAround(point, axis, Time.deltaTime * 200);
        }
        else if (num == 2)
        {           
            transform.RotateAround(point, axis, Time.deltaTime * 300);
        }
        else
        {
            transform.RotateAround(point, axis, Time.deltaTime * 20);
        }

    }

}
