using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField playerNameInputField;
    private DataManager dataManager;
    // Start is called before the first frame update
    public void StartNewGame() {
        string playerName = "Player";
        if (playerNameInputField.text != "")
            playerName = playerNameInputField.text;
        DataManager.Instance.playerName = playerName;
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
