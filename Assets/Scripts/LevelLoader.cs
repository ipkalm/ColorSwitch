using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        //if (scene.name == "Menu" && Input.GetMouseButtonDown(0))
        //{
        //    SceneManager.LoadScene("MainGame");
        //}
        //else if (scene.name == "MainGame" && Input.GetKeyDown(KeyCode.Escape))
        //{
        //    SceneManager.LoadScene("Menu");
        //}
        //else if (scene.name == "Menu" && Input.GetKeyDown(KeyCode.Escape))
        //{

        //}

        if (scene.name == "Menu")
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("MainGame");
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        else if (scene.name == "MainGame")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
