using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrubManager : MonoBehaviour
{
    //
    public SimulationManager simulationManager;
    //TODO: Distribution type affects how trees are distributed
    enum DistributionType { Random }

    public Shrub shrubPrefab; //prefab used to generate shrubs
    public float numShrubs; //total number of trees used in simulation

    // Start is called before the first frame update
    void Start()
    {
        this.numShrubs = this.simulationManager.numShrubs;

        //TODO: Chose distribution type by enum
        for (float i = numShrubs; i > 0; i--) 
        {
            Shrub shrub = Instantiate
                (
                shrubPrefab,
                new Vector3
                    (
                        Random.Range(this.simulationManager.minXBound, this.simulationManager.maxXBound),
                        Random.Range(this.simulationManager.minYBound, this.simulationManager.maxYBound),
                        1.0f
                    ),
                Quaternion.identity
                );
            shrub.transform.SetParent(this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO: Create factory method
}
