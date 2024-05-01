using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        { return; }

        Debug.Log("player collide with this.");
        SceneManager.LoadScene("SelectLevelScene");
     }
}

