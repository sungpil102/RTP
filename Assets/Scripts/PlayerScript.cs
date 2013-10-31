using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]

public class PlayerScript : MonoBehaviour {
	public AudioClip boing;
	public float walkSpeed = 10f;
	public float rotationSpeed = 100.0f;
	public float gravity = 10f;
	
	CharacterController controller;
	Transform body;
	GameObject camera;
	Vector3 moveVector;
	private Animation anim;
	AudioSource audiosource;
	CollisionFlags collisionFlags;
	
	// Use this for initialization
	void Start () {
		body = transform.FindChild("Body");
		controller = GetComponent<CharacterController>();
		if(body!=null){
			body.renderer.material.color = Color.green;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(body!=null){
			float inputRotate = Input.GetAxis("Horizontal");
			moveVector = body.transform.forward*walkSpeed*Input.GetAxis("Vertical")*Time.deltaTime;
			this.transform.Rotate(new Vector3(0,Input.GetAxis("Horizontal")*rotationSpeed*Time.deltaTime,0));
			collisionFlags = controller.Move(moveVector+new Vector3(0,-gravity*Time.deltaTime,0));
		}
	}
}
