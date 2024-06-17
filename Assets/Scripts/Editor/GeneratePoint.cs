using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Random = UnityEngine.Random;
public class GeneratePoint : MonoBehaviour
{
    [MenuItem("Tools/GeneratePoint")]
    // Start is called before the first frame update
    public static void Generate() {
        print("Generate Point");
        string parentTransformName = "Cube";
        int num = 200;
        GameObject parentTransform = GameObject.Find(parentTransformName);
        GameObject Sphere = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Sphere.prefab");
        for (int j = 0; j < num; j++) {
            List<float> values = new List<float>();
            for (int i = 0; i < 3; i++) {
                values.Add(Random.Range(-5f, 5f));
            }
            Vector3 pos = new Vector3(values[0], values[1], values[2]);
            pos += parentTransform.transform.position;
            GameObject go = new GameObject("Point" + j);
            go.transform.position = pos;
            go.transform.parent = parentTransform.transform;  
            Instantiate(Sphere, go.transform);
        }
        //point.AddComponent<Point>();
    }
}
