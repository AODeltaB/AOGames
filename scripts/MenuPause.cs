using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MenuPause : MonoBehaviour {


public static bool isActive = false;
public GameObject menu_Button;
public AudioSource audioSource;
public Transform Player;


void Update () {

    if(Input.GetKeyDown(KeyCode.Escape))
    {
        RESUME_BUTTON();
    }
    
    if(isActive == true) //  && lifecounter_pb.PlayerIsDead == false
    {
        Player.GetComponent<FirstPersonController>().enabled = false;   // Désactive le FPS Controller
        audioSource.mute = true; // Mute la musique
        menu_Button.SetActive(true); // Affiche le Menu Pause
        Cursor.visible = true; // Affiche le curseur
        Cursor.lockState = CursorLockMode.Confined; // Curseur bougeable
        Time.timeScale = 0; // Arrête les animations
    } else {
        Player.GetComponent<FirstPersonController>().enabled = true;   // Réactive le FPS Controller
       	audioSource.mute = false; // Unmute la musique
        menu_Button.SetActive(false); // Désactive le menu Pause
        Cursor.visible = false; // Désactive le curseur
        Cursor.lockState = CursorLockMode.Locked; // Bloque le curseur au milieu de l'écran
        Time.timeScale = 1; // Joue les animations
    }
   
}
    
    public void RESUME_BUTTON() {
    isActive = !isActive;
}

}

