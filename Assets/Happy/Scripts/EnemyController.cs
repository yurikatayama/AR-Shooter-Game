using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour{

    public GameObject baseObj;
    [Range (1,100)] public float velocidade, oi;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void Update () {
        transform.LookAt (baseObj.transform);
        rb.velocity += transform.forward * velocidade * Time.deltaTime;
    }
}
