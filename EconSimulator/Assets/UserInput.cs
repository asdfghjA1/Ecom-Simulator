using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UserInput : MonoBehaviour

{
    public float raycast_length;
    Vector3 startPos_cylinder;
    public Transform transform_cylinder;


    // Start is called before the first frame update
    private void Awake(){
        startPos_cylinder = transform_cylinder.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Draw(transform.position, transform.forward * raycast_length, Color.red);
        MoveLeftRight();
    }
    void MoveLeftRight(){
        Vector3 vec_left = Vector3.zero;
        vec_left.x = Input.GetAxis("Horizontal");
        Vector3 v = new Vector3(vec_left.x , 0.0f , 0.0f) * Time.deltaTime * 15.0f;
        transform_cylinder.Translate(v, Space.Self);
    }
}
