using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main_menu : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score.text = $"HIGH SCORE: {staticVal.angBest}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goToNext()
    {
 
        SceneManager.LoadScene(6);
    }
    
}
