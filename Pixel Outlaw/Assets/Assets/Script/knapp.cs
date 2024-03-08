using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToLoadScene : MonoBehaviour
{
    public string Spill; // the name of the scene to load

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Spill");
    }
}