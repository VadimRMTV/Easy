using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speedCar = 100;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speedCar);
        transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
    }
}

