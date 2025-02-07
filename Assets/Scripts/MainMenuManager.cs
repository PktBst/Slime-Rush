using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu  
{
    public class MainMenuManager : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(1); 
        }

        public void QuitGame() 
        {
            Application.Quit();
            Debug.Log("Game is exiting..."); 
        }
    }
}
