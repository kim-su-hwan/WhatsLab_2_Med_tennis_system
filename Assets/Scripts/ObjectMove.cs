using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed = 2.0f;
    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }


    //[SerializeField] private float speed = 10;
    //void Update()
    //{
    //    Moving();
    //}
    //void Moving()
    //{
    //    //float hor = Input.GetAxis("Horizontal");        //왼쪽, 오른쪽 키 
    //    float ver = Input.GetAxis("Vertical");          //앞, 뒤 키

    //    transform.Translate(Vector3.forward * speed * ver * Time.deltaTime);      //이동
    //                                                                              //transform.Rotate(Vector3.up * speed/5 * hor);

    //    if (Input.GetKey(KeyCode.LeftArrow))
    //        transform.Rotate(0.0f, -1.5f, 0.0f);
    //    else if (Input.GetKey(KeyCode.RightArrow))
    //        transform.Rotate(0.0f, 1.5f, 0.0f);
    //}
}
