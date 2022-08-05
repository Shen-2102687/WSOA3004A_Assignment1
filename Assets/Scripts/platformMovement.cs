using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
