using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class color : MonoBehaviour
{
    public float Speed = 10f;
    public int a, b, c;
    public GameObject sphere;
    public Text x;
    public GameObject cam;
    public GameObject bcam;
    void Start()
    {

    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }
        if (c <= 0)
        {
            cam.SetActive(true);
            bcam.SetActive(false);
            this.gameObject.SetActive(false);
            x.text = "Game over";
        }
        else x.text = c.ToString(); 
    }

    private void OnCollisionEnter(Collider collision)
    {

    }
    private void OnCollisionExit(Collider collision)
    {

    }
    private void OnCollisionStay(Collider collision)
    {

    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
    private void OnCollisionStay(Collider other)
    {

    }

}  
