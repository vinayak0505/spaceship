using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float _speed = 2f;

    void Start()
    {
        // transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(1 * Horizontal, 0, 1) * Time.deltaTime * _speed);

        // if(transform.position.x > 16f)
        //     {
        //         transform.position = new Vector3(16f,transform.position.y,transform.position.z);
        //     }

        //     if(transform.position.x < -16f)
        //     {
        //         transform.position = new Vector3(-16f,transform.position.y,transform.position.z);
        //     }

    }


    private void OnTriggerStay(Collider other) {
        Debug.Log("workging");
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("workging");
        // if(other.tag == "New Cube")
        // {
        //     transform.localScale += new Vector3(1,1,1);
        //     Destroy(other.gameObject);
        // }

        if(other.tag == "Bad Cube")
        {
            Destroy(other.gameObject);
            Debug.Log("game over");
        }
    }
}
