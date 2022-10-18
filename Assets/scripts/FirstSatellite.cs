using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSatellite : MonoBehaviour
{

    public GameObject target;
    public float rotateSpeed;

    private void Awake()
    {
        rotateSpeed = target.GetComponent<start>().rotateSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(target.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
    }
}
