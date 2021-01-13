using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadOnClick : MonoBehaviour {

    public void LoadScene()
    {
        string level = "GAME_" + GetComponentInChildren<Text>().text;
        SceneManager.LoadScene(level);
    }

}
