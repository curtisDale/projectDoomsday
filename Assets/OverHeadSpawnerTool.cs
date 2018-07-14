using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverHeadSpawnerTool : MonoBehaviour
{


    public Camera camera;
    public GameObject Tool;
    public Transform objectToInstantiate;
    public float offsetY;
    public float movementRange;
    public float meshRange;
    public float rotationSpeed;
    public GameObject FX;
    public GameObject collisionObject;


    // Use this for initialization
    void Start()
    {
        Tool.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, movementRange))
        {
            Tool.GetComponent<MeshRenderer>().enabled = true;
            Transform objectHit = hit.transform;
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.collider.gameObject.name == "Terrain")
            {
                offsetY = hit.point.y;

                Debug.Log("hit terrain");



                ////////////code that moves the object to the raycast hit point


                Tool.transform.position = hit.point;
                //Tool.transform.position = hit.point + (hit.transform.up);
            }
        }
        if ((hit.distance > meshRange))
        {
            Tool.GetComponent<MeshRenderer>().enabled = false;
        }
        if (Input.GetButton("circle"))
        {
            Tool.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("Spawn");
        }
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(0);
        Instantiate(objectToInstantiate, Tool.transform.position, Tool.transform.rotation);
        Instantiate(FX, Tool.transform.position, Tool.transform.rotation);
    }
    void OnCollision(Collision other)
    {
        //if (other.gameObject.tag == "barricade")
        // {
        //if (Input.GetButtonDown("Fire1"))
        //print("fuckyes");
        {
            Tool.GetComponent<MeshRenderer>().enabled = false;
        }
        // }
    }
}