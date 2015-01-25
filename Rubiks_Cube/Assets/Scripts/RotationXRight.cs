using UnityEngine;
using System.Collections;

public class RotationXRight : MonoBehaviour {
	
	
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
			if(Input.GetKeyDown(KeyCode.T)){
				inMotionForward = true;

			}else if(Input.GetKeyDown(KeyCode.Y)){
				inMotionBackward = true;
			}
		}
		
		if(inMotionForward){
			if(angle + turnSpeed * Time.deltaTime < 90){
				transform.RotateAround(position, Vector3.left, turnSpeed * Time.deltaTime);
				angle += turnSpeed * Time.deltaTime;

			}else if(angle < 90){
				transform.RotateAround(position, Vector3.left, 90 - angle);
				angle += turnSpeed * Time.deltaTime;

			}else{
				angle = 0;
				inMotionForward = false;
			}
		}
		if(inMotionBackward){
			if(angle + turnSpeed * Time.deltaTime < 90){
				transform.RotateAround(position, Vector3.right, turnSpeed * Time.deltaTime);
				angle += turnSpeed * Time.deltaTime;

			}else if(angle < 90){
				transform.RotateAround(position, Vector3.right, 90 - angle);
				angle += turnSpeed * Time.deltaTime;

			}else{
				angle = 0;
				inMotionBackward = false;
			}
		}
	}
}
