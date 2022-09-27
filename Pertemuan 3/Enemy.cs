using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    //Dhiki Sujatmiko_A11.2020.12619
    {
       if(Player.transform.position.x < transform.position.x){
                transform.position = new Vector3(
                transform.position.x - 2 * Time.deltaTime,
                transform.position.y,
                transform.position.z);
       }
       if(Player.transform.position.x > transform.position.x){
                transform.position = new Vector3(
                transform.position.x + 4 * Time.deltaTime,
                transform.position.y,
                transform.position.z);
       }
       if(Player.transform.position.y < transform.position.y){
                transform.position = new Vector3(
                transform.position.x,
                transform.position.y - 2 * Time.deltaTime,
                transform.position.z);
       }
        if(Player.transform.position.y > transform.position.y){
                transform.position = new Vector3(
                transform.position.x,
                transform.position.y + 2 * Time.deltaTime,
                transform.position.z);
       }
       if(Player.transform.position.z < transform.position.z){
                transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z  - 2 * Time.deltaTime);
       }
       if(Player.transform.position.z > transform.position.z){
                transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z  + 2 * Time.deltaTime);
       }
 
 
 
    }
}
