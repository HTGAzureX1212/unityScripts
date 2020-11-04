using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	public string objectName;
	public Rigidbody rb;
	public int h;
	int onornot = 0;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
    	if(col.gameObject.name == objectName){
    		Debug.Log("On ground statement is true.");
    		onornot = 1;
    	}
    }
    void Update(){
    	if (onornot == 1){
    		if (Input.GetKey("space")){
    			rb.AddForce(0, h, 0);
    			onornot = 0;
    		}
    	}
    }
}
