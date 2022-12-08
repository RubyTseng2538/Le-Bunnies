using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    private bool first = true;
    // Start is called before the first frame update


    public void ExecuteOnImapct()
    {
        if (first == false)
        {
            return;
        }
        this.transform.localScale = new Vector3(1,1,1);
        textComponent.text = string.Empty; 
        startDialogue();
        first = false;
    }

    // Update is called once per frame
    void startDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    IEnumerator TypeLine()
    {
        
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if (index < lines.Length-1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else{
            gameObject.SetActive(false);
        }
    }
}
