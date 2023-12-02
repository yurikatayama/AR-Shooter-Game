using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour{

    public int vida;
    public int speed;
    public GameObject alvo;
    public Rigidbody corpo;
    public GameRules rj;

    private void  Start () { //é a velocidade e a vida dos inimigos no inicio do jogo
        rj = GameObject.Find ("GameRules").GetComponent<GameRules>();
        corpo = GetComponent <Rigidbody> ();
        speed = 5;
        vida = 10 + (2 * rj.wave);
    }

    private void Update () {
        if (Vector3.Distance (this.transform.position, alvo.transform.position) > 0) {//quando o inimigo colidir ele para
            Movimentar ();
        } else {
            Morrer (1);

        }

        if (vida <=0) {
            Morrer (0);
        }
    } 
    public void ReceberDano (int danoRecebido) {//define o dano recebido pelo inimigo ao colidir com o tiro
        vida -= danoRecebido;
    }

    public int CausarDano () {//define o dano causado pelo inimigo na base (dano = vida do inimigo)
        return vida;
    }

    public void Morrer (int atraso) {//é onde o inimigo vai ser destruido
        Destroy(this.gameObject, atraso);
    }

    public void Movimentar () {//é a direção que o inimigo vai e a velocidade dele
        transform.LookAt (alvo.transform);
        corpo.velocity = transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) {//define a colisão do inimico com o tiro
        if (other.gameObject.tag == "Tiro") {
            Destroy (other.gameObject);
            Destroy (this.gameObject);
        }
        if (other.gameObject.tag == "Base") {
            Destroy (this.gameObject);
        }

    }
}
