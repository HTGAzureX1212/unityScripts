using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMM : MonoBehaviour
{




	public Transform t;
	public Rigidbody rb;
	public float mSpeed;
	public int rSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a")){
        	t.Rotate(0, -rSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("d")){
        	t.Rotate(0, rSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("w")){
        	rb.AddRelativeForce(Vector3.forward * mSpeed);
        }
        if (Input.GetKey("s")){
        	rb.AddRelativeForce(-Vector3.forward * mSpeed);
        }
    }
}
