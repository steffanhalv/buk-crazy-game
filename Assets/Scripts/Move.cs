using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    bool down = false;
    bool up = false;
    bool right = false;
    bool left = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (left)
        {
            Vector3 position = this.transform.position;
            position.x -= 0.01f;
            this.transform.position = position;
        }
        else if (right)
        {
            Vector3 position = this.transform.position;
            position.x += 0.01f;
            this.transform.position = position;
        }
        else if (up)
        {
            Vector3 position = this.transform.position;
            position.y += 0.01f;
            this.transform.position = position;
        }
        else if (down)
        {
            Vector3 position = this.transform.position;
            position.y -= 0.01f;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right = true;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up = true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left = false;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right = false;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            up = false;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            down = false;
        }
    }

}
