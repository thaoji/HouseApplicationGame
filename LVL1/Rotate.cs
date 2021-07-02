using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Component Door;
    public GameObject Key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
    }

    void OnTriggerStay()
    {
       if (Input.GetKey(KeyCode.E))
            {
            Door.GetComponent<BoxCollider>().enabled = true;

            }
        else
        {

        }
        if (Input.GetKey(KeyCode.E))
        {
            Key.SetActive(false);

        }

    }


}
