using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneSwitcher : MonoBehaviour
{
    public string sceneA = "VRMainScene"; // Name of your first scene
    public string sceneB = "Menu"; // Name of your second scene

    void Update()
    {
        // Press V to load scene A
        if (Input.GetKeyDown(KeyCode.V))
        {
            SceneManager.LoadScene(sceneA);
        }

        // Press Escape to load scene B
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneB);
        }
    }
}