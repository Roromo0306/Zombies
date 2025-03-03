using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidad = 10;
    float CoordX, CoordZ;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CoordX = Input.GetAxisRaw("Horizontal"); ;
        CoordZ = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(CoordX * velocidad,  0, CoordZ * velocidad );
        rb.velocity = vector;   
    }
}
