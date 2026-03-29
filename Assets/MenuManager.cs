using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("KitchenLevel");
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}