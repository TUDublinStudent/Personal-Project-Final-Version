using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string Url = "https://github.com/TUDublinStudent/Personal-Project-Alpha";

    public void Play()
    {
        SceneManager.LoadScene("My Scene");
    }

    public void loadUrl()
    {
        Application.OpenURL(Url);
    }
}
