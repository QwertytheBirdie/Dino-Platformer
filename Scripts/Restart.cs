using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    [SerializeField] private string resetScene = "MainScreen";

    public void StartButton()
    {
        SceneManager.LoadScene(resetScene);
    }
}

