using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour
{

    public Button b1;
 

    void Start()
    {
        b1.enabled = false;

    }
    public void load()  //wczytanie zmiennych wczeœniej zapisnachy w pliku
    {
        staticVal.load();
    }
}
