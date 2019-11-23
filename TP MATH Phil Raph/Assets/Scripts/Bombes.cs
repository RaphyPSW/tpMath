using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombes : MonoBehaviour
{
    public float rayon;
    public float originalForce;
    const float e = 2.7183f;
    public int courbeDistri;
    List<Building> buildinglist;
    List<int> partlist;
    

    void Start()
    {
        rayon = 10;
        originalForce = 10;
        courbeDistri = 5;
        foreach (Building b in buildinglist) {

           
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
