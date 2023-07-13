using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartNewGame() {
        SceneManager.LoadScene(1);
    }

    public void ExitGame() {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
