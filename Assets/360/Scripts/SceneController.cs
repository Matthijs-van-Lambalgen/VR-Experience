using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MKBWerkplaats()
    {
        SceneManager.LoadScene("MKB Werkplaats");
    }

    public void Cartesius()
    {
        SceneManager.LoadScene("Cartesius");
    }

    public void Celciushuis()
    {
        SceneManager.LoadScene("Celciushuis");
    }

    public void HUOekraïneProject()
    {
        SceneManager.LoadScene("HU Oekraïne Project");
    }
}
