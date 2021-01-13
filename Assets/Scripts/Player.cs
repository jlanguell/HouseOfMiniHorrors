using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public Text information;

	void Start(){

		// Grab current scene name
		Scene currentScene = SceneManager.GetActiveScene();
		string sceneName = currentScene.name;

		if (sceneName == "GAME_FindTheSwitch")
		{
			information.text = "Find the lightswitch";
		}
		else if (sceneName == "GAME_DrawerShuffle")
        {
			information.text = "Find the knife";
        }
		else if (sceneName == "GAME_KnifeToss")
        {
			information.text = "Don't kill Eric...";
        }

	}
}
