using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class litterSpawner : MonoBehaviour
{
    private Vector3[] positions = { new Vector3 { x = -5, y = 1, z = 0 },
                         new Vector3 { x = 5, y = 1, z = 0}, new Vector3{x = 0, y = 1, z = 5 }, new Vector3{x = 5, y = 1, z = 5 },
                         new Vector3{x = -5, y = 1, z = 5 }, new Vector3{x = 0, y = 1, z = 0 }, new Vector3{x = 0, y = 1, z = -5 },
                         new Vector3{x = 0, y = 1, z = -5 }};
    public GameObject trash1;
    public GameObject trash2;
    public GameObject trash3;
    public GameObject recycle1;
    public GameObject recycle2;
    public GameObject recycle3;
    public GameObject compost1;
    public GameObject compost2;
    public GameObject compost3;
    public int totalLitter = 10;
    private List<GameObject> items = new List<GameObject>();

    bool isObjectHere(Vector3 position)
    {
        Collider[] intersecting = Physics.OverlapSphere(position, 0.01f);
        if (intersecting.Length != 0)
        {
            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        items.Add(trash1);
        items.Add(trash2);
        items.Add(trash3);
        items.Add(recycle1);
        items.Add(recycle2);
        items.Add(recycle3);
        items.Add(compost1);
        items.Add(compost2);
        items.Add(compost3);
        //int elem = random.Next(2);
        if (Input.GetMouseButtonUp(1))
        {
            int elem = (int) Random.Range(0f, 8f);
            int gameObj = (int) Random.Range(0f, 9f);
            while (isObjectHere(positions[elem]) == true)
            {
                elem = (int)Random.Range(0f, 8f);
            }
            if (totalLitter > 0)
            {
                Instantiate(items[gameObj], positions[elem], Quaternion.identity);
                totalLitter--;
            } else
            {
                Debug.Log("No more litter available");
            }
            
        }
    }

}
