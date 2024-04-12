using UnityEngine;
using UnityEngine.AI;

public class NavigationAgentControl : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] MovingPlayer[] target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        InvokeRepeating("Reapete", .5f, 5f);
    }
    void Reapete()
    {
        target = FindObjectsOfType<MovingPlayer>();

        if(target.Length == 0) return;
        // targetIndex = Random.Range(0, 2);
        int rand = Random.Range(0, target.Length);
        agent.destination = target[rand].transform.position;
        Debug.Log(rand);
    }
}
