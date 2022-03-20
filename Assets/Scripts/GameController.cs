using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool isGameRunning;
    public GameObject PauseUI;

    public void OpenUI(){
        PauseUI.SetActive(true);
        isGameRunning = false;
    }

    public void CloseUI(){
        PauseUI.SetActive(false);
        isGameRunning = true;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
