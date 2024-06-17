using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameUIManager : MonoBehaviour
{
    public List<Transform> poss;
    public void 粮仓1_pos_btn() {
        Camera.main.GetComponent<CameraManager>().cameraPos = poss[0].position;
    }
    public void 粮仓2_pos_btn() {
        Camera.main.GetComponent<CameraManager>().cameraPos = poss[1].position;
    }
    public void Quit_btn() {
        SceneManager.LoadScene("start");
    }
}
