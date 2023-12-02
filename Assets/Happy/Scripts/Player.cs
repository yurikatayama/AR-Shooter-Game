using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject tiroPrefab;
    public Transform spawnPoint;
    public float dano, cadencia;
    public bool firing;
    public Touch tot;

    private void Update () {

        if (Input.touchCount > 0) {
            tot = Input.GetTouch (0);
            firing = (tot.phase == TouchPhase.Began || tot.phase == TouchPhase.Moved);
        }

        if (firing) {
            cadencia -= 1 * Time.deltaTime;
            if (cadencia <= 0) {
                Instantiate (tiroPrefab, spawnPoint.position, this.transform.rotation);
                cadencia = 0.1f;
            }
        }
    }

}