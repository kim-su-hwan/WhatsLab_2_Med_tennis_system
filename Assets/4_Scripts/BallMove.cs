using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    private bool isHit = false;

    // Update is called once per frame
    void Update()
    {
        if(!isHit)
        {
            transform.position = Vector3.Lerp(gameObject.transform.position,target.transform.position, Time.deltaTime);
        }
    }
}
