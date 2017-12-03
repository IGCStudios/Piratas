using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBarco : MonoBehaviour {

    GameObject player;
    Rigidbody2D rigidPlayerShip;
    public float BaseSpeed { get; set; }
    public Vector3 WindSpeed { get; set; }

    public List<Transform> rightCannons;
    public List<Transform> leftCannons;

	void Start () {
        BaseSpeed = 1f;
        WindSpeed = new Vector3(0, 0, 0) ;
        player = GameObject.FindGameObjectWithTag("Player");
        rigidPlayerShip = player.GetComponentInChildren<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rotateRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotateLeft();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            shootLeftCannons();
        }
      
    }

    private void FixedUpdate()
    {
        rigidPlayerShip.velocity = ( - rigidPlayerShip.GetComponent<Transform>().transform.up * (BaseSpeed ) + WindSpeed  );
        //rigidPlayerShip.gameObject.transform.position += -rigidPlayerShip.GetComponent<Transform>().transform.up * (BaseSpeed);


    }

    public void rotateRight()
    {
      // rigidPlayerShip.gameObject.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime, Space.World);
        rigidPlayerShip.MoveRotation(rigidPlayerShip.rotation - 0.05f);
        // rigidPlayerShip.MoveRotation(rigidPlayerShip.rotation+1);
        Debug.Log(" rotando " + rigidPlayerShip.rotation );
    }
    public void rotateLeft()
    {
        rigidPlayerShip.MoveRotation(rigidPlayerShip.rotation + 0.05f);
       // rigidPlayerShip.gameObject.transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * BaseSpeed, Space.World);
        Debug.Log(" rotando");
    }

    void ShootRightCannons()
    {

    }
    void ShootLeftCannons()
    {

    }
}
