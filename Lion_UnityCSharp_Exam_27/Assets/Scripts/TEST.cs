using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    [Header("移動物件")]
    public Transform move;
    [Header("前強往位置")]
    public Transform target;
    [Header("移動速度"), Range(1, 100)]
    public float speed;

    Vector3 targetPosition = new Vector3(10, 0, 0);   
    Vector3 currentVelocity = Vector3.zero;    
    float maxSpeed = 20f;    
    float smoothTime = 3f;      

     void Update()
     {
         transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime, maxSpeed);

     }
    /*private IEnumerator Move()
    {
        float dis = Vector3.Distance(move.position, target.position);

        while (dis >= 0.2f)
        {
            move.position = Vector3.Lerp(move.position, target.position, Time.deltaTime * 0.5f * speed);
            yield return null;
        }

    }*/
}
