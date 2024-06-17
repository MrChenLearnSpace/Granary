using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Vector3 cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate() {
        transform.position = Lerp(transform.position, cameraPos, 0.1f);
        
    }
    Vector3 Lerp(Vector3 a, Vector3 b, float t) {
        return a + (b - a) * t;
    }
}
