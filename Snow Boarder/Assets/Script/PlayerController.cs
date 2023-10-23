using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 20f;
    void Start()
    {
       rb2d  = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       if ( Input.GetKey(KeyCode.LeftArrow)){
         rb2d.AddTorque(torqueAmount);
       }
       else if ( Input.GetKey(KeyCode.RightArrow)){
         rb2d.AddTorque(-torqueAmount);
       }
    }
}
