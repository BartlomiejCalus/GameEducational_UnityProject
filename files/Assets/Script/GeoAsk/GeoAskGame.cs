using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeoAskGame : MonoBehaviour
{
    public Text txtPanstwo;
    public InputField infStolica;

    private List<Quest> quests;
    private int nr;

    void Start()
    {
        if (staticVal.nxt)
        {
            resetList();
            staticVal.nxt = false;
        }     
        else
        {
            quests = staticVal.ans;
            getStolica();
        }
            
    }

    void Update()
    {
        
    }
    public void check()
    {
        if(infStolica.text == quests[nr].stolica)
        {
            staticVal.ileGeoAsk++;
            quests.Remove(quests[nr]);
            infStolica.text = "";
            staticVal.ans = quests;
            getStolica();
        }
    } 
    private void getStolica()
    {
        nr = Random.Range(0, quests.Count);
        txtPanstwo.text = quests[nr].panstwo;
    }
    public void resetList()
    {
        quests = staticVal.Quests;
        staticVal.ileGeoAsk = 0;
        getStolica();
    }
}
