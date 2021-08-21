using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExplode : MonoBehaviour
{
    [SerializeField] ParticleSystem collectParticle = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Collect();
        }
        //if (collectParticle && !collectParticle.isEmitting)
        //{
        //    Destroy(gameObject);
        //    Debug.Log("Stop");
        //}
    }

    public void Collect()
    {
        collectParticle.Play();
        Destroy(gameObject);


        //if(ParticleSystemStopAction.Callback )
        //{
        //    var main = collectParticle.main;
        //    main.stopAction = ParticleSystemStopAction.Callback;
        //}
    }

    //void OnParticleSystemStopped()
    //{
    //    Destroy(gameObject);
    //    Debug.Log("Stop");
    //}


    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.CompareTag("bomb"))
    //    {
    //        GetComponent<ParticleSystem>().Play();
    //        Destroy(enemy);
    //    }
    //}
}
