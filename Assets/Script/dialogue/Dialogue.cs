using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //dzieki temu mo�na tego u�ywa� wsz�dzie
//klsa bazowa dialogu
public class Dialogue
{
    public string name;

    [TextArea(3,10)]
    public string[] sentences;

}
