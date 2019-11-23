using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    List<GameObject> buildingList;
    List<GameObject> buildingParts;
    [SerializeField] GameObject brickBuilding;
    [SerializeField] GameObject metalBuilding;
    [SerializeField] GameObject woodBuilding;

    private void Awake()
    {
        brickBuilding = Resources.Load<GameObject>("Prefabs/Brick building");
        metalBuilding = Resources.Load<GameObject>("Prefabs/Metal building");
        woodBuilding = Resources.Load<GameObject>("Prefabs/Wood building");

        
        buildingList[0] = woodBuilding;
        buildingList[1] = brickBuilding;
        buildingList[2] = metalBuilding;
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
