using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject gamePaused;

    // Update is called once per frame
    void Update()
    {
        inGameMenu();
    }
    public void selectLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitApps()
    {
        Application.Quit();
        Debug.Log("Aplikasi dihentikan");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void sosmed1()
    {
        Application.OpenURL("www.facebook.com");
    }

    public void keranjang()
    {
        Application.OpenURL("https://assetstore.unity.com/");
    }

    public void google()
    {
        Application.OpenURL("https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fwww.google.com%2Fsearch%3Fq%3Dlogin%2Bgoogle%26oq%3D%26gs_lcrp%3DEgZjaHJvbWUqCQgAECMYJxjqAjIJCAAQIxgnGOoCMgkIARAjGCcY6gIyCQgCECMYJxjqAjIJCAMQIxgnGOoCMgkIBBAjGCcY6gIyCQgFECMYJxjqAjIJCAYQIxgnGOoCMgkIBxAjGCcY6gLSAQ0xMzI5NTAyODJqMGo3qAIIsAIB8QWWbttH4e7BYg%26sourceid%3Dchrome%26ie%3DUTF-8&ec=GAlAAQ&hl=id&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S554259071%3A1751219157359467");
    }

    public void inGameMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            gamePaused.SetActive(true);
        }
    }

    public void levelReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void unPaused()
    {
            Time.timeScale = 1;
            gamePaused.SetActive(false);
    }
}
