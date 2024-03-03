using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void QuitGame()
  {
    Application.Quit();
  }
  public void Play()
  {
    SceneManager.LoadSceneAsync(2);
  }
  public void Pokedex(){
    SceneManager.LoadSceneAsync(1);
  }
  public void BackToMenu()
  {
    SceneManager.LoadSceneAsync(0);
  }
}
