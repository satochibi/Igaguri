using UnityEngine;
using System.Collections;

public class IgaguriController : MonoBehaviour {


	public void Shoot(Vector3 dir){
		this.GetComponent<Rigidbody> ().AddForce (dir);
	}

	// Use this for initialization
	void Start () {
		//Shoot (new Vector3(0, 200, 2000));
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision other){
		this.GetComponent<Rigidbody>().isKinematic = true;
		this.GetComponent<ParticleSystem> ().Play ();
	}
}
