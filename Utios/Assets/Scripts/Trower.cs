using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trower : MonoBehaviour
{
    public Transform[] placesToThrowObject;

    //Require object to be rigidBody
    public Rigidbody ObjectToThrow;

    public float speedToThrow = 300f;

	void Start ()
    {
        ThrowObject();

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    void ThrowObject()
    {
        //int randNumber = Mathf.Abs(Random.Range(1, 7));

        //Utworz obiekt, przypisz do rodzica i ustaw jego pozycję
        Rigidbody objToThrow = Instantiate(ObjectToThrow,
                                 placesToThrowObject[0].transform.position,
                                 Quaternion.identity) as Rigidbody;

        //Rzuć obiekt
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        objToThrow.AddForce(fwd * -speedToThrow);
    }
}
