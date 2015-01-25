using UnityEngine;
using System.Collections;

public class RotationYTop : MonoBehaviour {
	
	
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
			if(Input.GetKeyDown(KeyCode.W)){
				inMotionForward = true;

			}else if(Input.GetKeyDown(KeyCode.O)){
				inMotionBackward = true;
			}
		}
		
		if(inMotionForward){
			if(angle + turnSpeed * Time.deltaTime < 90){
				transform.RotateAround(position, Vector3.up, turnSpeed * Time.deltaTime);
				angle += turnSpeed * Time.deltaTime;

			}else if(angle < 90){
				transform.RotateAround(position, Vector3.up, 90 - angle);
				angle += turnSpeed * Time.deltaTime;

			}else{
				angle = 0;
				inMotionForward = false;
			}
		}
		if(inMotionBackward){
			if(angle + turnSpeed * Time.deltaTime < 90){
				transform.RotateAround(position, Vector3.down, turnSpeed * Time.deltaTime);
				angle += turnSpeed * Time.deltaTime;

			}else if(angle < 90){
				transform.RotateAround(position, Vector3.down, 90 - angle);
				angle += turnSpeed * Time.deltaTime;

			}else{
				angle = 0;
				inMotionBackward = false;
			}
		}
	}
}
