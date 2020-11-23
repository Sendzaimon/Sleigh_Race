using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointLearn : MonoBehaviour
{

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Finn")
        {
            SceneManager.LoadScene(0);
Debug.Log("Finish");
        }
    }
}
