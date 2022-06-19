using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //dzieki temu mo¿na tego u¿ywaæ wszêdzie
public class Quest
{
    public string panstwo;
    public string stolica;

    public Quest(string panstwo, string stolica)
    {
        this.panstwo = panstwo;
        this.stolica = stolica;
    }
}
