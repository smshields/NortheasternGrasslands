using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassManager : MonoBehaviour
{
    public SimulationManager simulationManager;

    public Grass grassPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
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
