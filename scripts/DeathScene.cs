using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScene : MonoBehaviour {

	// Use this for initialization
	void Update () {
		    
            Cursor.visible = true; // Affiche le curseur
            Cursor.lockState = CursorLockMode.None; // Active la possibilité de bouger le curseur          
	}
	
	// Update is called once per frame
	public void ExitMainMenu(string Level) {

	SceneManager.LoadScene(Level);
	}
}
