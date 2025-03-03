using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform player;
    public int speed = 2;
    public float detectionRange = 10f;
    public float FOV = 180f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionPlayer = (player.position - transform.position).normalized;  
        float distancePlayer = Vector3.Distance(transform.position, player.position);

        float dotProduct = Vector3.Dot(transform.forward, directionPlayer);
        float angleToPlayer= Mathf.Acos(dotProduct) * Mathf.Rad2Deg;

        if (distancePlayer < detectionRange && angleToPlayer < FOV / 2)
        {
            transform.position = Vector3.Lerp(transform.position, player.position, speed* Time.deltaTime);
            Quaternion targetRotation = Quaternion.LookRotation(directionPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed* Time.deltaTime);   
        }

       
    }
}
