using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            // win
            // ..
            FindObjectOfType<whenGameComplated>().callThisWhenGameWin();
            Invoke("loadScene", 0.2f);
            Debug.Log("Maze Win");
        }
    }

    void loadScene()
    {
        FindObjectOfType<loadScene>().LoadScene(1); // home scene 1
    }
}