using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class MovingAI : MonoBehaviour
{
    [SerializeField] private float Radius = 20;
    [SerializeField] private bool Debug_Bool;

    NavMeshAgent My_Agent;
    Vector3 Next_Position;
    // Start is called before the first frame update
    void Start()
    {
        My_Agent = GetComponent<NavMeshAgent>();
        Next_Position = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Next_Position, transform.position) <= 1.5f){
            Next_Position = GenericRandomPointGenerator.R_Point_ge(transform.position, Radius);
            My_Agent.SetDestination(Next_Position);
        }
        
    }
    void onDrawGizmos(){
        if(Debug_Bool == true){
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, Next_Position);
        }
    }
}
