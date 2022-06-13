using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScript : MonoBehaviour
{
    
    public Text[] answers;
    public Text[] words;
    public InputField[] ipF;

    private string[] ang = new string[] {"cat","dog"};
    private string[] pl = new string[] {"kot","pies"};

    private int what_word;
    private bool next = false;
    bool git = false;

    void Start()
    {
        for (int i = 0; i<words.Length; ++i)
        {
            what_word = Random.Range(0, ang.Length);
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
                what_word = Random.Range(0, ang.Length);
                words[i].text = ang[what_word];
                ipF[i].text="";
            }
        }
    }

    public void checkAns()
    {
        for(int i =0; answers.Length > i; ++i)
        {
            for (int j = 0; j < pl.Length; ++j)
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
        next = git;
    }
}
