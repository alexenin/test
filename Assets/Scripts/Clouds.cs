using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour {

    private float speed = 0.1f, yPos;

    void Start()
    {
        speed = Random.Range(0, 10) > 5 ? speed : -speed;
        yPos = transform.position.y; //Начальное значение по оси y

    }

    void Update()
    {
        if (transform.position.y >= yPos + 0.1f || transform.position.y <= yPos - 0.1f)
            speed = -speed;
        transform.position += new Vector3(0, speed * Time.deltaTime, 0); //Двигаем тучки
    }
}
