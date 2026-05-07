using UnityEngine;
using System.Collections.Generic;

public class flyinf : MonoBehaviour
{
    private Rigidbody Rigidb;
    public List<GameObject> waypoints;
    public float speed;
    private int Selectedwaypoint;
    private int OldSelectedWaypoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Selectedwaypoint = Random.Range(0, waypoints.Count - 1);
        OldSelectedWaypoint = Selectedwaypoint;
        Rigidb = gameObject.GetComponent<Rigidbody>();
        gameObject.transform.LookAt(waypoints[Selectedwaypoint].transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "waypoints")
        {
            while (OldSelectedWaypoint == Selectedwaypoint)
            {
                Selectedwaypoint = Random.Range(0, waypoints.Count - 1);
                if(Selectedwaypoint != OldSelectedWaypoint)
                {

                   break;
                }
            }
            OldSelectedWaypoint = Selectedwaypoint;

        }
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.LookAt(waypoints[Selectedwaypoint].transform.position);
        Rigidb.linearVelocity = gameObject.transform.forward * speed;
            
    }
}
