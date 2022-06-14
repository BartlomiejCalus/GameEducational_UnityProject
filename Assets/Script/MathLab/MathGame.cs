using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MathGame : MonoBehaviour
{

    private int ans;
    private int point;
    private int my_ans;

    bool time = false;

    private int a;
    private int b;
    private int znak;
    private int what_ans;
    private int correct;

    private float currTime;

    public Text pytanie;
    public Text countdown;
    public Text points;
    public GameObject CD;

    public Text odpA;
    public Text odpB;
    public Text odpC;
    public Text odpD;

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;

    public GameObject bStart;

    public GameObject heartCont;
    public GameObject[] hearts;
    private int cnt = 2;

    void Start()
    {
        b1.enabled = false;
        b2.enabled = false;
        b3.enabled = false;
        b4.enabled = false;

        heartCont.SetActive(false);
    }

     void Update()
    {
        currTime -= Time.deltaTime;
        countdown.text = currTime.ToString("0.0");
        if (currTime <= 0f)
            CD.SetActive(false);

        if (currTime <= 0f && time)
        {
            pytanie.text = "Koniec czasu";
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;

            time = false;
        }
        if (cnt == -1)
        {
            SceneManager.LoadScene(0);
        }
    }

   
    //który przycisk wciœniêty
    public void GetAns (int x)
    {
        ans = x;
    }

    //wciœniêcie "START"
    public void StartGame()
    {
        heartCont.SetActive(true);
        Destroy(bStart); //schowanie "START"
        

        time = true;

        b1.enabled = true;
        b2.enabled = true;
        b3.enabled = true;
        b4.enabled = true; //pokazanie przycisków

        
        
        switch (staticVal.dif) //jaki poziom trudnoœci jest wybrany
        {
            case 1:
                currTime = 60f;
                CD.SetActive(true); //ustawienie stopera na 15s i pokazanie go
                Debug.Log("easy");
                Qest1();
                break;

            case 2:
                currTime = 60f;
                CD.SetActive(true); //ustawienie stopera na 20s i pokazanie go
                Debug.Log("medium");
                Qest2();
                break;

            case 3:
                currTime = 60f;
                CD.SetActive(true); //ustawienie stopera na 20s i pokazanie go
                Debug.Log("hard");
                Qest3();
                break;

            default:
                pytanie.text = "COŒ NIE DZIA£A";
                break;
            }
            
        
    }

    // POZIOM £ATWY
    public void Qest1()
    {

        a = Random.Range(-100, 101);
        b = Random.Range(-100, 101);
        znak = Random.Range(0, 2);
        

        if (znak == 1)
        {
            pytanie.text = a.ToString() + " + " + b.ToString();
            correct = a + b;
        }
        else if(znak == 0)
        {
            pytanie.text = a.ToString() + " - " + b.ToString();
            correct = a - b;
        }

        my_ans = RandANS(100);
    
    }

    // POZIOM ŒREDNI
    public void Qest2()
    {

        a = Random.Range(-20, 21);
        b = Random.Range(-5, 6);

        pytanie.text = "("+a.ToString() + ") * (" + b.ToString()+")";
        correct = a * b;

        my_ans = RandANS(100);
    
    }

    // POZIOM TRUDNY
    public void Qest3()
    {

        a = Random.Range(-50, 51);
        b = Random.Range(-10, 11);

        pytanie.text = "(" + a.ToString() + ") * (" + b.ToString() + ")";
        correct = a * b;

        my_ans = RandANS(500);
       
    }

    // losowanie pozycji poprawnej odpowiedzi
    public int RandANS(int przedzial)
    {
        what_ans = Random.Range(1, 5);

        switch (what_ans)
        {
            case 1:
                odpA.text = correct.ToString();
                odpB.text = Random.Range(-przedzial, przedzial).ToString();
                odpC.text = Random.Range(-przedzial, przedzial).ToString();
                odpD.text = Random.Range(-przedzial, przedzial).ToString();
                break;

            case 2:
                odpA.text = Random.Range(-przedzial, przedzial).ToString();
                odpB.text = correct.ToString();
                odpC.text = Random.Range(-przedzial, przedzial).ToString();
                odpD.text = Random.Range(-przedzial, przedzial).ToString();
                break;

            case 3:
                odpA.text = Random.Range(-przedzial, przedzial).ToString();
                odpB.text = Random.Range(-przedzial, przedzial).ToString();
                odpC.text = correct.ToString();
                odpD.text = Random.Range(-przedzial, przedzial).ToString();
                break;

            case 4:

                odpA.text = Random.Range(-przedzial, przedzial).ToString();
                odpB.text = Random.Range(-przedzial, przedzial).ToString();
                odpC.text = Random.Range(-przedzial, przedzial).ToString();
                odpD.text = correct.ToString();
                break;
        }
        return what_ans;

    }
    public void What_Qest()
    {
        

        switch (staticVal.dif)
        {
            case 1:
                if (my_ans == ans)
                {
                    point++;
                    points.text = point.ToString();

                    if (staticVal.theBest[0] < point)
                    {
                        staticVal.theBest[0] = point;
                        staticVal.save();
                    }     
                }
                else { takeHeart(); }

                Qest1();
                break;
            case 2:
                if (my_ans == ans)
                {
                    point++;
                    points.text = point.ToString();

                    if (staticVal.theBest[1] < point)
                    {
                        staticVal.theBest[1] = point;
                        staticVal.save();
                    }      
                }
                else { takeHeart(); }

                Qest2();
                break;
            case 3:
                if (my_ans == ans)
                {
                    point++;
                    points.text = point.ToString();

                    if (staticVal.theBest[2] < point)
                    {
                        staticVal.theBest[2] = point;
                        staticVal.save();
                    }    
                }
                else { takeHeart(); }

                Qest3();
                break;
        }
    }
    public void takeHeart()
    {
        if(cnt>0)
        Destroy(hearts[cnt]);
        
        cnt--;
    }
}

