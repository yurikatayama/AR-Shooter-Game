using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {
    public int velocidade = 1500;
    public Rigidbody rb;
    public float timer = 3;

    private void Awake () {
        rb = GetComponent<Rigidbody> ();
    }

    private void Update () {
        //rb.AddForce (new Vector3 (0, 0, -velocidade * Time.deltaTime), ForceMode.Impulse);
        //rb.velocity = Vector3.forward * velocidade * Time.deltaTime;
        transform.Translate (Vector3.forward * velocidade * Time.deltaTime);
        timer -= 1 * Time.deltaTime;
        if (timer < 0) {
            Destroy (this.gameObject);
        }
    }
}