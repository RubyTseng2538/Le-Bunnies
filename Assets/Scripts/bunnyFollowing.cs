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
        
    }

    // Update is called once per frame
    void Update()
    {
        bunny.SetDestination(Player.position);
    }
}
