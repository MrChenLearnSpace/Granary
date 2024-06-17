using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void 立体粮仓仿真_btn() {
          SceneManager.LoadScene("SampleScene");
    }
    public void 分簇算法仿真_btn() {
          SceneManager.LoadScene("SampleScene");
    }
    public void 数据传输仿真_btn() {
          SceneManager.LoadScene("SampleScene");
    }
}
