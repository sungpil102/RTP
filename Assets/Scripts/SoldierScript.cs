using UnityEngine;
using System.Collections;

public class SoldierScript : MonoBehaviour {
	
	public float walkSpeed = 5f;
	public float rotationSpeed = 100.0f;
	public float gravity = 10f;
	public int owner = 0;
	private Animation anim;
	Vector3 moveVector;
	CollisionFlags collisionFlags;
	GameObject king;
	Transform body;
	public float distance = 3;
	
	// Use this for initialization
 	void Start () {
		king = GameObject.Find("Player");
		body = transform.FindChild("Body");
		if(body!=null){
			body.renderer.material.color = Color.blue;
		}
		walkSpeed = Random.Range(50,100)/10f;
		body.animation["Bounce"].speed = Random.Range(50,100)/100f;
		body.animation.Play("Bounce");
	}
	
	// Update is called once per frame
	void Update () {
		if(owner==0){
			Follow (king);
		}
	}
	
	void Follow(GameObject target){
		Quaternion direction = Quaternion.LookRotation(target.transform.position-transform.position);
		direction.z = 0;
		direction.x = 0;
		transform.rotation = Quaternion.Slerp(transform.rotation,direction , rotationSpeed*Time.deltaTime);
		if(Vector3.Distance(king.transform.position,transform.position)>distance){
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, walkSpeed*Time.deltaTime);
		}		
	}
	
	void OnCollisionEnter(Collision c){
		Debug.Log(c.gameObject.GetComponent<SoldierScript>().owner);
	}
}
