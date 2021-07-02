using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    public Component Door2;
    public GameObject Key2;

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
            Door2.GetComponent<BoxCollider>().enabled = true;

        }
        if (Input.GetKey(KeyCode.E))
        {
            Key2.SetActive(false);

        }

    }


}
