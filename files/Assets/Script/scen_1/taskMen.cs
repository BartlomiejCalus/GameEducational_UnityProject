using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class taskMen : MonoBehaviour
{
    public GameObject[] ans = new GameObject[3];
    private string[] bin = new string [3];
    public Text[] label = new Text[3];
    public Animator animator;


    void Start()
    {
        setBin();
    }

    public void CheckTask()
    {
        
        //animator.SetBool("IsGood", false);
        
        for (int i = 0; i < 3; ++i)
        {
            if (int.Parse(ans[i].GetComponent<Text>().text) == pow(bin[i]))
                Debug.Log(ans[i].GetComponent<Text>().text + ".Dzia³a");
            else
            {
                Debug.Log(ans[i].GetComponent<Text>().text + ".Nie dzia³a");
                return;
            }
        }
        
        //animator.SetBool("IsOpen", false);
        SceneManager.LoadScene(2);
    }

    private void setBin()
    {
        for(int i = 0; i < 3; ++i)
        {
            for(int j=0; j < 8; ++j)
                bin[i] += Random.Range(0, 2).ToString();
            label[i].text = bin[i];
            Debug.Log(bin[i]);
        }
    }
    private static string znaki = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int pow(string n)
    {
        int wynik = 0;
        int x;
        int p = 1;
        for (int i = n.Length - 1; i >= 0; i--)
        {
            x = valueOf(n[i]);
            if (x < 0)
            {
                return 0;
            }
            wynik += (x * p);
            p *= 2;
        }

        return wynik;
    }
    private static int valueOf(char x)
    {
        for (int i = 0; i < 2; i++)
        {
            if (x == znaki[i])
            {
                return i;
            }
        }
        return -1;
    }

}
