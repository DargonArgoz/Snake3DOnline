using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : NetworkBehaviour
{
    [SerializeField] GameObject cameraCM;
    public override void OnStartAuthority()
    {
        cameraCM.SetActive(true);
    }
}
