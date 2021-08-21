using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField]
    private float _speed = 2f;
    void Update()
    {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * _speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Asteroid")
        {
            Destroy(other.gameObject);
        }
    }
}
