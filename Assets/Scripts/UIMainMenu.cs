using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMainMenu : MonoBehaviour
{
    public InputField playerName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        if (!string.IsNullOrWhiteSpace(playerName.text))
        {
            GameManager.Instance.playerName = playerName.text;
            SceneManager.LoadScene(1);
        }
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
