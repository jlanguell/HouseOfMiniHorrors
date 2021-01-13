using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class KnifeRotation : MonoBehaviour
{
    //number of targets hit
    public static int numCorrect;

    public Transform tempTrans;
    public GameObject object1;
    public GameObject object2;

    //aSprite is empty or stores one of the other sprite values 
    public SpriteRenderer aSprite;
    public SpriteRenderer leftSprite;
    public SpriteRenderer rightSprite;
    public SpriteRenderer bottomSprite;

    //eric is the SpriteRenderer for his dead/alive state (sprite)
    public SpriteRenderer eric;
    public Sprite liveEric;
    public Sprite deadEric;

    //stores bool, remembers which targets have already been hit to ensure each is only used once per numCorrect
    public static bool left;
    public static bool right;
    public static bool bottom;

    //is Eric alive?
    public static bool alive;

    //unused, but could store specific RGB 
    public Color greenColor;

	void Awake()
    {
        //initialize game variables
        left = false;
        right = false;
        bottom = false;
        numCorrect = 0;
        alive = true;
    }

    void Update()
    {
        
    }

    //method triggers when a knife is thrown
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //for each knife thrown, relocates knife under parent, "KnifeToss_Background"
        tempTrans = object2.transform.parent;
        object2.transform.parent = object1.transform;

        //if statement to end game if eric dies (losing)
        if (collision.gameObject.tag == "ERICBODY")
        {
            alive = false;
            eric.sprite = deadEric;
            StartCoroutine(EndCoroutine());

        }
        //elseif, elseif, elseif for each of eric's targets, if hit, returns true flag and numCorrect +=1 (max of 3)
        else if (collision.gameObject.tag == "LT")
        {
            Debug.Log("YOUUUHITTTHEELEFTHEAD");
            aSprite = leftSprite;
            aSprite.color = Color.green;
            if (left == false)
            {
                numCorrect += 1;
                left = true;
                Debug.Log(numCorrect);
            }
        }
        else if (collision.gameObject.tag == "RT")
        {
            Debug.Log("YOUUUHITTTHEERIGHTHEAD");
            aSprite = rightSprite;
            aSprite.color = Color.green;
            if (right == false)
            {
                numCorrect += 1;
                right = true;
                Debug.Log(numCorrect);
            }

        }
        else if (collision.gameObject.tag == "LEGS")
        {
            Debug.Log("YOUUUHITTTHEELEGS");
            aSprite = bottomSprite;
            aSprite.color = Color.green;
            if (bottom == false)
            {
                numCorrect += 1;
                bottom = true;
                Debug.Log(numCorrect);
            }
        }
        if (numCorrect == 3) //winning 
        {
            Debug.Log("YOU WIN! Be Easy Eric.");
            StartCoroutine(EndCoroutine());
            GUI.Label(new Rect(10, 10, 100, 20), "YOU WIN");

        }
    }
    

    IEnumerator EndCoroutine() //after game is played
    {
        //Revert the parent of object 2
        object2.transform.parent = tempTrans;
        //unlock cursor
        Cursor.lockState = CursorLockMode.None;
        //wait 3
        yield return new WaitForSeconds(3f);
        //restore Eric sprite
        eric.sprite = liveEric;
        //return to menu
        SceneManager.LoadScene("DebugMenu");
    }
}
