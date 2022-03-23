using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SandboxManager : MonoBehaviour
{
    public GoalController blueGoal;
    public GoalController redGoal;
    public TMP_Text textScoreboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textScoreboard.text = blueGoal.point + " - " + redGoal.point;

        if (redGoal.point >= 3) {
            textScoreboard.text = "Red Win!";
        }
        if (blueGoal.point >= 3) {
            textScoreboard.text = "Blue Win!";
        }
    }

    public void GoToHome() {
        SceneManager.LoadScene("Home");
    }
}
