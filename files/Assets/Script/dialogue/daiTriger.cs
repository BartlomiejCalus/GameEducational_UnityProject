using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daiTriger : MonoBehaviour
{

    public Dialogue dialogue;

    //wywo�anie ca�ego zestawu do dialogu po stworzeniu
    public void Start()
    {
        FindObjectOfType<objDialog>().StartDialog(dialogue);
    }

    //wywo�anie ca�ego dialogu po wci�ni�ciu przycisku
    public void IsTrigger()
    {
        FindObjectOfType<objDialog>().StartDialog(dialogue);
    }
    
}
