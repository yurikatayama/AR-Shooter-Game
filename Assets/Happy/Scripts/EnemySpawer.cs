using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawer : MonoBehaviour{

    [SerializeField][Range (1,60)] private float timer;
    [SerializeField] private Vector3 posicaoSpawn;
    public GameObject enemyPrefab;
    private float aux;
    

    private void Start() {
        aux = 0;
        posicaoSpawn = this.transform.position;
        posicaoSpawn.y += 0.2f;
    }

    private void Update() {
        aux += 1 * Time.deltaTime;
        if (aux >= timer) {
            aux = 0;
            Instantiate (enemyPrefab, posicaoSpawn, Quaternion.identity, this.gameObject.transform);
        }
    }

}
