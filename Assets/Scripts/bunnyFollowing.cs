using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bunnyFollowing : MonoBehaviour
{
    public NavMeshAgent bunny;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.Find("vBasicController_Jane").transform;
        }
        if (bunny == null)
        {
            bunny = gameObject.GetComponent<NavMeshAgent>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        bunny.SetDestination(Player.position);
        
    }
}
