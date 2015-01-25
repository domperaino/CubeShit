using UnityEngine;
using System.Collections;

public class RotationZRight : MonoBehaviour {
	
	
	bool inMotionForward = false;
	bool inMotionBackward = false;

	Vector3 position;
	float angle;
	
	public float turnSpeed = 90;
	
	void Start(){
		position = GameObject.FindWithTag("Center").transform.position;
	}
	
	void Update(){
		if(!inMotionForward && !inMotionBackward){
			if(Input.GetKeyDown(KeyCode.Q)){
				inMotionForward = true;

			}else if(Input.GetKeyDown(KeyCode.A)){
				inMotionBackward = true;
			}
		}
		
		if(inMotionForward){
			if(angle + turnSpeed * Time.deltaTime < 90){
				transform.RotateAround(position, Vector3.forward, turnSpeed * Time.deltaTime);
				angle += turnSpeed * Time.deltaTime;

			}else if(angle < 90){
				transform.RotateAround(position, Vector3.forward, 90 - angle);
				angle += turnSpeed * Time.deltaTime;

			}else{
				angle = 0;
				inMotionForward = false;
			}
		}
		if(inMotionBackward){
			if(angle + turnSpeed * Time.deltaTime < 90){
				transform.RotateAround(position, Vector3.back, turnSpeed * Time.deltaTime);
				angle += turnSpeed * Time.deltaTime;

			}else if(angle < 90){
				transform.RotateAround(position, Vector3.back, 90 - angle);
				angle += turnSpeed * Time.deltaTime;

			}else{
				angle = 0;
				inMotionBackward = false;
			}
		}
	}
}
