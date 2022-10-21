using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private GameObject launchPanel;
    [SerializeField] private GameObject game;
    private void Start()
    {
        game.SetActive(false);
        victoryPanel.SetActive(false);
        launchPanel.SetActive(true);
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void StartAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void GameLaunch()
    {
        launchPanel.SetActive(false);
        game.SetActive(true);
    }

    public void GameOver()
    {
        victoryPanel.SetActive(true);
        game.SetActive(false);
    }
}
