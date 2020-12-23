using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //     var speed = 5.0;
    // // Update is called once per frame
    // void Update()
    // {
    //     var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed; var z = Input.GetAxis("Vertical") * Time.deltaTime * speed; transform.Translate(x, 0, z);
    // }
//     float speed = 5f;
 
 void Update () {
    // float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    // float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
    int a=1;
    // while True:
    // {
        transform.Translate(0.09f, 0, 0);
    // }
        
  
 }
    // float target = Transform;
//  float distance = 3f;
//  float height = 3f;
//  float damping = 5f;
//  bool smoothRotation = true;
//  float rotationDamping = 10f;
 
//  void Update () {
//      float wantedPosition = transform.TransformPoint(0, height, -distance);
//      transform.position = Vector3.Lerp (transform.position, wantedPosition, Time.deltaTime * damping);
 
//      if (smoothRotation) {
//          var wantedRotation = Quaternion.LookRotation(transform.position - transform.position, transform.up);
//          transform.rotation = Quaternion.Slerp (transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
//      }
 
//      else transform.LookAt (transform, transform.up);
//  }


// var target : Transform;
//  var distance = 3.0;
//  var height = 3.0;
//  var damping = 5.0;
//  var smoothRotation = true;
//  var rotationDamping = 10.0;
 
//  function Update () {
//      var wantedPosition = target.TransformPoint(0, height, -distance);
//      transform.position = Vector3.Lerp (transform.position, wantedPosition, Time.deltaTime * damping);
 
//      if (smoothRotation) {
//          var wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
//          transform.rotation = Quaternion.Slerp (transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
//      }
 
//      else transform.LookAt (target, target.up);
//  }
}
