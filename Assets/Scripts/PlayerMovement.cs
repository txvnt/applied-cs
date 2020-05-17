using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody; 
    public float speed;
    public float jumpForce;

    public GameObject prefab;

    float tiempo = 5;
    public Text contador;
    bool contando = true;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        GameObject go = Instantiate(prefab); //Instanciar prefab de plataforma
        contador.text = "Tiempo: 5";
    }

    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(movementX * speed, movementY * jumpForce);
        rigidbody.AddForce(movement);

        if(contando){
            tiempo -= Time.deltaTime;
            contador.text = "Tiempo: " + (tiempo).ToString();
        }

        if(tiempo < 0) {
            Debug.Log("Perdiste");
            contando = false;
        }
    }
}
