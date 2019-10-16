using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour {
    //Toutes les actions que peut faire le joueur avec l'UI
    public void close() {
        Application.Quit();
    }
    public void rejouer() {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
