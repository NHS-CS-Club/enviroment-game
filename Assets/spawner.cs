using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    private static int treeCounter = 0;
    private static int seedCounter = 0;
    public int treeLimit;
    public int totalSeeds;


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < totalSeeds; i++)
        {
            Instantiate()
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (treeCounter < treeLimit)
            {
                Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
                treeCounter++;
                seedCounter--;
            }
            if (treeCounter >= treeLimit)
            {
                Debug.Log("No more trees available");
            }
        }
    }
}
