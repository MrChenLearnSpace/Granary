using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public GameObject pointPrefab;
    public List<Transform> points;
    public List<Color> colors;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < points.Count; i++) {
           GameObject go = Instantiate(pointPrefab, points[i]);
            go.GetComponent<Renderer>().material.SetColor("_MainColor",colors[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
