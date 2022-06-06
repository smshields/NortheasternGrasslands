using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    public GameObject grasslandFloor;
    public BoxCollider grasslandFloorCol;

    // Simulation Settings [TODO: Add in enum for different types of distributions for objects]
    public float numTrees = 100;
    public float minXBound;
    public float maxXBound;
    public float minYBound;
    public float maxYBound;

    void Awake() 
    {
        this.minXBound = this.grasslandFloorCol.bounds.min.x;
        this.maxXBound = this.grasslandFloorCol.bounds.max.x;
        this.minYBound = this.grasslandFloorCol.bounds.min.y;
        this.maxYBound = this.grasslandFloorCol.bounds.max.y;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
