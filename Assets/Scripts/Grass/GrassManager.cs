using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassManager : MonoBehaviour
{
    //Simulation Manager reference. Linked via Unity.
    public SimulationManager simulationManager;

    public Grass grassPrefab; //prefab used to generate grass
    public float numStartingGrass; //initial number of grass used in simulation

    // Start is called before the first frame update
    void Start()
    {
        this.numStartingGrass = simulationManager.numStartingGrass;

        for (float i = this.numStartingGrass; i > 0; i--) 
        {
            //TODO: fix Z number hardcoding
            Grass grass = Instantiate
                (
                grassPrefab,
                new Vector3
                    (
                    Random.Range(this.simulationManager.minXBound, this.simulationManager.maxXBound),
                    Random.Range(this.simulationManager.minYBound, this.simulationManager.maxYBound),
                    1f
                    ),
                Quaternion.identity
                );
            grass.transform.SetParent(this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Add a new Grass to the manager
    //TODO: Pass grass stats
    public void AddGrass(Vector3 grassPos) //position
    {
        Grass grass = Instantiate
            (
            grassPrefab,
            grassPos,
            Quaternion.identity
            );
        grass.transform.SetParent(this.transform);
    }

}
