using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 1000;

    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed);
  
if (Input.GetButtonDown("Fire1")) {
            GameObject bullet = Instantiate(bulletPrefab, transform.position + Vector3.up*2, transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * 1000;
            Destroy(bullet, 4);
        }
   }
}
