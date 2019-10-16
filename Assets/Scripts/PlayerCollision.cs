using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Gere toutes les collisions du joueurs
public class PlayerCollision : MonoBehaviour {
    private int lives = 3;
    public float buffer = 3f; //Duree d invincibilite
    private float timer; //Mesure le temps avant fin d'invincibiilte
    private bool is_invulnerable = false;
    private Material player_material; //Permet de changer la couleur du joueur
    private Color original_color; //Conserver la couleur d'origine du joueur
    public Sprite lives0; //Les sprites correspondant aux differents etats de la barre de vie
    public Sprite lives1;
    public Sprite lives2;
    public Sprite lives3;
    public Image health_bar; //L'image de la barre de vie

    public GameObject gameOver; //L'UI correspondant au game over

    private void Start() {
        health_bar.sprite = lives3;
        timer = 0f;
        player_material = transform.gameObject.GetComponent<Renderer>().material;
        original_color = player_material.GetColor("_Color");
    }
    private void Update() {
        if (is_invulnerable) {
            updateBuffer();
        }
    }
    private void OnCollisionEnter(Collision collision) {
        string type = collision.transform.tag;
        if (!is_invulnerable) {
            if (type == "BadFloor") { //Si l'utilisateur tombe
                transform.position = new Vector3(-21f, 1.5f, 108f);
                lives -= 1;
                launchBuffer(Color.cyan);
            }
            if (type == "Enemy") { //Si l'utilisateur est touche par un ennemi
                lives -= 1;
                launchBuffer(Color.cyan);
            }
            if (type == "Vie") { //Si l'utilisateur prend un bonus de vie
                Destroy(collision.gameObject); //On detruit l'objet
                lives += 1;
                launchBuffer(Color.red);
                if (lives > 3)
                    lives = 3;
            }
            if (type == "Star") { //Si l'utilisateur prend un bonus d'invincibilite
                Destroy(collision.gameObject);
                launchBuffer(Color.yellow, 7f);
            }
        }
        switch (lives) { //Choisir la bonne sprite pour la barre de vie
            case 3:
                health_bar.sprite = lives3;
                break;
            case 2:
                health_bar.sprite = lives2;
                break;
            case 1:
                health_bar.sprite = lives1;
                break;
            default:
                health_bar.sprite = lives0;
                gameOver.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                transform.position = new Vector3(1000, 1000, 1000);
                break;
        }
    }
    private void launchBuffer(Color c, float t = 0f) { //Buffer d'invincibilite
        timer = 0f - t;
        player_material.SetColor("_Color", c);
        is_invulnerable = true;
    }
    private void updateBuffer() { //Mise a jour du buffer
        Debug.Log(timer);
        timer += Time.deltaTime;
        if(timer > buffer) {
            player_material.SetColor("_Color", original_color);
            is_invulnerable = false;
        }
    }
}
