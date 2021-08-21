using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetSript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _forwardSpeed = 10f;

    [SerializeField] 
    private float _movementSpeed = 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * _forwardSpeed);
        transform.Translate(new Vector3(0,Vertical, -Horizontal) * Time.deltaTime * _movementSpeed);

        if (transform.position.y > 20f)
        {
            transform.position = new Vector3(transform.position.x, 20f, transform.position.z);
        }

        if (transform.position.y < -20f)
        {
            transform.position = new Vector3(transform.position.x, 20f, transform.position.z);
        }
        if (transform.position.z > 20f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 20f);
        }

        if (transform.position.z < -20f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 20f);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("workgin");
        Debug.Log(other.tag);
    }
}
