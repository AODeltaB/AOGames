using UnityEngine;
using UnityEngine.UI;

public class lifecounter_pb : MonoBehaviour
{

    public Slider LifeBar; // Notre Slider LifeBar
    public Text life_progressBarText; // Le texte value de la vie
    public GameObject DeathScreen; // Pannel

    // Variables d'initialisation
    public float startingHealth = 100; // Comme dans tous jeux, la vie est set à 100
    public float currentHealth; // oyeah
    public bool PlayerIsDead = false; // Variable booléenne pour dire si le joueur est mort ou non


    void Start()
    {
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

        if (currentHealth <= .0f) // test si t'es mort ou non
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            PlayerIsDead = true; // Mets le joueur "mort"
            DeathScreen.SetActive(true); // Active l'écran noir "You died"
            Time.timeScale = 0; // Arrête les animations
        }
        else
        {
            DeathScreen.SetActive(false); // Si le joueur n'est pas mort alors on désactive l'écran
            Time.timeScale = 1; // et on joue les animations
        }
        life_progressBarText.text = currentHealth * 100f + " HP"; // Récupère en string currentHealth * 100 et rajoute HP
    }
}