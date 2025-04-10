using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
    public class stuff 
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public stuff(int bul, int gre, int roc) 
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;


        }
    }

    public stuff myStuff = new stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Update()
    {
        Movement();
        Shoot();
    }

    // Update is called once per frame
    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
    }
    void Shoot() 
    {
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0) 
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;

        }


    }
}
