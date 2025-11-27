using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    NavMeshAgent agent;
    [SerializeField] private Transform player;
    public bool speed = false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}

