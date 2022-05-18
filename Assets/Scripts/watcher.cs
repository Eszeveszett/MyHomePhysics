using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watcher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10;
    public float rotateInput = 25;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, rotateInput * horizontalInput * Time.deltaTime);
    }
}
