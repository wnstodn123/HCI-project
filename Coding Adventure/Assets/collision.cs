using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    Renderer objectColor;
    private bool isClick;
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        objectColor = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        isClick = false;
    }

    private void OnMouseUp()
    {
        isClick = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        objectColor.material.color = Color.gray;
    }

    private void OnTriggerStay(Collider other)
    {
        if (isClick)
        {
            Destroy(other.gameObject);
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            objectColor.material.color = Color.black;
            Debug.Log("hi");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        objectColor.material.color = Color.black;
    }
}
