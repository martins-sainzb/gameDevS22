using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        GameData.Score += 10;

        Debug.Log(GameData.Score);

        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
