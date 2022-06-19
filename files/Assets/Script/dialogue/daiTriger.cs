using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daiTriger : MonoBehaviour
{

    public Dialogue dialogue;

    //wywo³anie ca³ego zestawu do dialogu po stworzeniu
    public void Start()
    {
        FindObjectOfType<objDialog>().StartDialog(dialogue);
    }

    //wywo³anie ca³ego dialogu po wciœniêciu przycisku
    public void IsTrigger()
    {
        FindObjectOfType<objDialog>().StartDialog(dialogue);
    }
    
}
