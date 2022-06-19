using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main_menuGeo : MonoBehaviour
{
    public Text wynik;
    // Start is called before the first frame update
    void Start()
    {
        wynik.text = $"{staticVal.ileGeoAsk}/{staticVal.Quests.Count}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goToAdd()
    {

        SceneManager.LoadScene(8);
    }
}
