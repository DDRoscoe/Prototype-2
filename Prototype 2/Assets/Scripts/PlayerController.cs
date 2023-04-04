using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab; // this is how to reference a prefab on the object associated with the script
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange) // if they hit the boundary,
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); // set their position to remain at -10 without changing y or z
        }
        if (transform.position.x > xRange) // if they hit the boundary,
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); // set their position to remain at 10 without changing y or z
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // Instantiate creates copies of a prefab
        }
    }
}
