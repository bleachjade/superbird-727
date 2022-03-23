using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public void PlaySandBox() {
        SceneManager.LoadScene("Sandbox");
    }
    public void PlaySuperBird() {
        SceneManager.LoadScene("SuperBird");
    }
}
