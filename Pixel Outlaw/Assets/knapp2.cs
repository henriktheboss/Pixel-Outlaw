using UnityEngine;
using UnityEngine.SceneManagement;

public class knapp2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Spill");
    }
}