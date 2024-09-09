using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private GlobalStringWar _globalStringWar;

    public float horizontalInput;
    public float verticalInput;
    public float jumpInput;

    private void Update()
    {
        DataInput();
    }

    private void DataInput()
    {
        horizontalInput = Input.GetAxis(GlobalStringWar.horizontal);
        verticalInput = Input.GetAxis(GlobalStringWar.vertical);
        jumpInput = Input.GetAxis(GlobalStringWar.jump);
    }
}
