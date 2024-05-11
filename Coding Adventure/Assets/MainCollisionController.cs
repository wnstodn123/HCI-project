using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainCollisionController : MonoBehaviour
{
    Renderer objectColor;
    public GameObject Cube;
    public InputActionProperty leftGrip;
    public InputActionProperty rightGrip;

    // Start is called before the first frame update
    void Start()
    {
        objectColor = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        objectColor.material.color = Color.gray;
    }
    
    private void OnTriggerStay(Collider other)
    {
        float LGValue = leftGrip.action.ReadValue<float>();
        float RGValue = rightGrip.action.ReadValue<float>();

        if (LGValue == 0 && RGValue == 0)
        {
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            objectColor.material.color = Color.black;
            GameObject newCube = Instantiate(Cube) as GameObject;
            newCube.transform.SetParent(this.gameObject.transform, false);
            newCube.transform.position = this.gameObject.transform.position + Vector3.up * 0.1f;

            Destroy(other.gameObject);
        }
    }
    

    private void OnTriggerExit(Collider other)
    {
        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        objectColor.material.color = Color.black;
    }
}
