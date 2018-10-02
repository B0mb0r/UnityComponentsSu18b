using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color newColor;
    public Transform other;
    [Range(-720, 720)]
    public float rotationsSpeed;

    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(0.3f, 0.6f, 0.2f);
        //other.position = new Vector3(3, 2, other.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(
            5f * Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(
                0f, 
                0f, 
                rotationsSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(
                0f, 
                0f, 
                -rotationsSpeed * Time.deltaTime);
        }
    }
}
