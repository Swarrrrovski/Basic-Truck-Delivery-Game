using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1 : MonoBehaviour
{
     [SerializeField] float SteerSpeed = 100;
    [SerializeField] float moveSpeed = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
         float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0, moveAmount,0);
    }
}
