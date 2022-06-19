using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MathLabScript : MonoBehaviour
{
    public Text easy_best;
    public Text medium_best;
    public Text hard_best;

    private void Start()
    {

        easy_best.text = staticVal.theBest[0].ToString();
        medium_best.text = staticVal.theBest[1].ToString();
        hard_best.text = staticVal.theBest[2].ToString();

        Debug.Log(staticVal.theBest[0] + "\n" + staticVal.theBest[1] + "\n" + staticVal.theBest[2] );
    }
    public void goToNext(int dif)
    {
        staticVal.dif = dif;
        Debug.Log(staticVal.dif);
        SceneManager.LoadScene(4);
    }

}
