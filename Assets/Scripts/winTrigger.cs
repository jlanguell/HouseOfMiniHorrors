using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winTrigger : MonoBehaviour {
    public AudioSource switch_flick;
    private bool audioHasPlayed = false;
	// Use this for initialization
	void Start () {
        this.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Camera.main.nearClipPlane));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (!audioHasPlayed)
        {
            switch_flick.PlayOneShot(switch_flick.clip);
            audioHasPlayed = true;
        }
        GameObject dark = GameObject.Find("darkness");
        dark.gameObject.SetActive(false);
        StartCoroutine(WinTheGame(1.5f));        
    }
    IEnumerator WinTheGame(float duration)
    {        
        yield return new WaitForSeconds(duration);        
        SceneManager.LoadScene("DebugMenu");
    }
}
