using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        float move =Input.GetAxis("Vertical"); //Кнопки w и s
        float rotate = Input.GetAxis("Horizontal"); //Кнопки a и d
        transform.Translate(Vector3.right * move * 2f * Time.deltaTime);
        //transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - move * 2f * Time.deltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + rotate * 20f * Time.deltaTime, transform.eulerAngles.z);
	}
}
