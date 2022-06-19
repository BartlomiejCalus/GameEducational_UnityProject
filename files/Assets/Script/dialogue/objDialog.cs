using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objDialog : MonoBehaviour
{

    private Queue<string> sentences;

    public Text nameTxt;
    public Text dialogueTxt;

    public Animator animator;
    void Start()
    {
        sentences = new Queue<string>();                                 
    }

    public void StartDialog (Dialogue dialogue)
    {
        nameTxt.text = dialogue.name;

        sentences.Clear(); //czyszczenie �mieci

        //p�tla po tablicy dialogu i wpisanie elementu do kolejki
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        ShowSentence();
    }
    
    public void ShowSentence()
    {
       if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue(); //�ci�gni�cie elementu z kolejki i przypisanie go do zmiennej

        StopAllCoroutines(); //jakby co� sobie dzia�a�o to ju� nie dzia�a
        StartCoroutine(TypeSen(sentence)); 

    }

    //metoda w kt�rej mo�na ustawi� odst�p czasowy
    IEnumerator TypeSen (string sen)
    {
        dialogueTxt.text = "";
        foreach (char letter in sen.ToCharArray())
        {
            dialogueTxt.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void EndDialogue()
    {
        Debug.Log("Koniec konwersacji");
        animator.SetBool("IsOpen", true);
    }

}
