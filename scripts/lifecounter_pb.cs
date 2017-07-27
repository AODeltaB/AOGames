using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;
public class lifecounter_pb : MonoBehaviour
{

    public Slider LifeBar; // Notre Slider LifeBar
    public Text life_progressBarText; // Le texte value de la vie
    public GameObject DeathScreen; // Pannel
    public Transform Player;
    // Variables d'initialisation
    private float startingHealth = 50; // Comme dans tous jeux, la vie est set à 100
    private float currentHealth; // oyeah
    public static bool PlayerIsDead = false; // Variable booléenne pour dire si le joueur est mort ou non

    void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = true;
        float calcul_pb = Mathf.Clamp01(startingHealth / .9f); // Calcul pour mettre 100 HP a 1 value Slider
        currentHealth = calcul_pb; // On initalise currentHealth a 1
    }

    void Update()
    {
        LifeBar.value = currentHealth;
        if (Input.GetKeyDown(KeyCode.L)) // Si on appuie sur "L"
        {
            if (currentHealth < .25f)
            {
                currentHealth = .0f; // Si il reste moins de 25HP + "L" => on reduit à 0 au lieu d'avoir un nombre négatif
            }
            else
            {
                currentHealth = currentHealth - .25f; // On perds 25 HP soit 0.25 value
            }
        }

        if (currentHealth <= .0f)// test si t'es mort ou non
        {
            PlayerIsDead = true; // Mets le joueur "mort"
        }

        if (PlayerIsDead)
        {
           // MenuPause.isActive = false;
        SceneManager.LoadScene("Assets/Scenes/DeathScene.unity");
        }
        life_progressBarText.text = currentHealth * 100f + " HP"; // Récupère en string currentHealth * 100 et rajoute HP
    }
}