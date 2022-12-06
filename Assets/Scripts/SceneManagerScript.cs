using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public GameObject bunnyPrefabReference, playerReference;
    public float areaX,areaY;
    private List<GameObject> bunnyList= new List<GameObject>();
    public DialogueScript dialogueReference;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("bunnyDrop",1f,10f);
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject bunny in bunnyList)
        {
            
            Vector3 playerDistance = playerReference.GetComponent<Transform>().position;
            float check = Vector3.Distance(bunny.GetComponent<Transform>().position,playerDistance);
            print(check);
            if (check < 1f)
            {
                dialogueReference.ExecuteOnImapct();
                
            }
        }

        //check if close enough to player
    }

    void bunnyDrop()
    {
        
        var temp = Instantiate(bunnyPrefabReference,new Vector3(Random.Range(-areaX,areaX)
            ,10,Random.Range(-areaY,areaY)),Quaternion.identity);

        bunnyList.Add(temp);

    }
}
