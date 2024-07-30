using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour {


    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;


    private void Awake() {
        playButton.onClick.AddListener(() => {
            int randomIndex = new System.Random().Next(7);
            if (randomIndex == 1)
            { 
                Loader.Load(Loader.Scene.GameScene1);
            }
            else if (randomIndex == 2)
            {
                Loader.Load(Loader.Scene.GameScene2);
            }
            else if (randomIndex == 3)
            {
                Loader.Load(Loader.Scene.GameScene3);
            }
            else if (randomIndex == 4)
            {
                Loader.Load(Loader.Scene.GameScene4);
            }
            else if (randomIndex == 5)
            {
                Loader.Load(Loader.Scene.GameScene5);
            }
            else if (randomIndex == 6)
            {
                Loader.Load(Loader.Scene.GameScene6);
            }
            else if (randomIndex == 7)
            {
                Loader.Load(Loader.Scene.GameScene7);
            }
        });
    }

}