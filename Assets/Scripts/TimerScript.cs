using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
    static float baseTime = 10.0f;
    public Text counter;
    private float timeLeft = baseTime;

	// Use this for initialization
	void Start () {
        timeLeft = timeLeft /*modify with difficulty*/ ;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeLeft >= 0.0)
        {
            timeLeft -= Time.deltaTime;            
        }
        else {
            timeLeft = 0.0f;
            //GameObject dark = GameObject.Find("darkness");
            //dark.GetComponent<Renderer>().material.color = UnityEngine.Color.red;
            //dark.gameObject.SetActive(false);
            StartCoroutine(GameFail(1.5f));
        }
        counter.text = Mathf.Round(timeLeft).ToString();
    }   

    IEnumerator GameFail(float duration)
    {
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene("DebugMenu");
        Cursor.lockState = CursorLockMode.None;
    }
}
