using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float SpeedGamePerSecond = 0.2f;
    [SerializeField] private float turnSpeed =200f;

    private int steerValue ;

    void Update()
    {
        speed += SpeedGamePerSecond * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    public void Steer(int value)
    {
        steerValue = value;
    }


    private void OnTriggerEnter(Collider other) {
        // if(other.tag == "Object"){
        //     SceneManager.LoadScene("EndGame");
        // }
        if(other.CompareTag("Object")){
            SceneManager.LoadScene("EndGame");
        }
    }
}
