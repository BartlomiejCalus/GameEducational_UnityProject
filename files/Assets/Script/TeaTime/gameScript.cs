using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameScript : MonoBehaviour
{
    public GameObject panel;

    public Text[] answers;
    public Text[] words;
    public InputField[] ipF;

    private List<string> ang = new List<string> { "cat", "dog" };
    private List<string> pl = new List<string> { "kot", "pies" };

    private int what_word;
    private bool next = false;
    bool git = false;

    public GameObject heartCont;
    public GameObject[] hearts;
    private int cnt = 2;

    public Text score;
    private int points = 0;


    void Start()
    {
        for (int i = 0; i<words.Length; ++i)
        {
            what_word = Random.Range(0, ang.Count);
            words[i].text = ang[what_word];
        }
    }

    void Update()
    {

        if (next)
        {
            next = false;
            git = false;
            for (int i = 0; i < words.Length; ++i)
            {
                what_word = Random.Range(0, ang.Count);
                words[i].text = ang[what_word];
                ipF[i].text="";
            }
        }
        if (cnt == -1)
        {
            SceneManager.LoadScene(0);

        }
    }

    public void checkAns()
    {
        for(int i =0; answers.Length > i; ++i)
        {
            for (int j = 0; j < pl.Count; ++j)
            {
                if (answers[i].text.ToLower() == pl[j])
                {
                    git = true;
                    break;
                }
                else 
                { 
                    git = false;
                }
            }
            if (!git) { break; }
        }
        if (!git)
        {
            takeHeart();
        }
        else
        {
            points++;
            score.text = $"SCORE: {points}";
            staticVal.angBest = points;
            staticVal.save();
        }
        
        next = git;
    }
    public void takeHeart()
    {
        if (cnt > 0)
            Destroy(hearts[cnt]);

        cnt--;
    }
    
}
