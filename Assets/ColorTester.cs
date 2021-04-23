using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTester : MonoBehaviour
{
    public GameObject player;
    public Material[] materials;

    public string test;

    private static readonly int Color = Shader.PropertyToID("_Color");

    // Start is called before the first frame update
    void Start()
    {
        
        materials = player.GetComponent<SkinnedMeshRenderer>().materials;
        foreach (Material m in materials)
        {
            test = m.name;
            Debug.Log(m.name);
            if (m.name == "Skin (Instance)")
            {
                m.SetColor(Color, new Color(1f, 0.04f, 0.92f));
                Debug.Log("ye");
            }

        }
        

        Debug.Log(materials);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
