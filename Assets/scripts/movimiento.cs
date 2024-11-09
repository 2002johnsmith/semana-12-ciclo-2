using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _ComponentRigiBody2D;
    private float horizontal;
    private float vertical;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        _ComponentRigiBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //if ((Input.GetKeyDown("")) == true)
        //{
        //    print("");
        //}
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        _ComponentRigiBody2D.velocity = new Vector2(horizontal*velocity*Time.deltaTime, vertical*velocity*Time.deltaTime);
    }
}
