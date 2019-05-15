using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTeleport : MonoBehaviour
{
    Scene currentScene;
    int sceneBuildIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneBuildIndex = currentScene.buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            switch (sceneBuildIndex)
            {
                case 0:
                    SceneManager.LoadScene(1);
                    break;
                case 1:
                    SceneManager.LoadScene(0);
                    break;
            }
        }
    }
}
