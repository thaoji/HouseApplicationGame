using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate3 : MonoBehaviour
{
    public Component Door3;
    public GameObject Key3;

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
            Door3.GetComponent<BoxCollider>().enabled = true;

        }
        if (Input.GetKey(KeyCode.E))
        {
            Key3.SetActive(false);

        }

    }
}
