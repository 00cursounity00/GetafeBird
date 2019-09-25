using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool playing = false;

    public static void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
