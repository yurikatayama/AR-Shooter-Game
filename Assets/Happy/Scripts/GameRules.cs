using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour{

    public int wave, poder, vida, cadencia;

    private void Start() {//define os status do do inimigo no inicio
        wave = 0;
        poder = 1;
        vida = 10;
        cadencia = 1;
    } 

    private void Update() {//caso a vida chegue a 0 perde o jogo
        if (vida <= 0) {
            GameOver ();
        }
    }

    public void ReceberDano ( int dano) {//é o dano causado pelo inimigo na base (dano = vida do inimigo)
        vida -= dano;
    }

    public void GameOver () {//caso o jogo seja perdido ele para
        Time.timeScale = 0; 
    }

    private void OnCollisionEnter(Collision other) {//define a colisão do inimigo com a base
        if (other.gameObject.tag == "enemy") {
           // ReceberDano (other.gameObject.CausarDano());
        }
    }

}
