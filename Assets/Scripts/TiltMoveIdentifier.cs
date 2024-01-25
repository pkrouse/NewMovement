using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMoveIdentifier : MonoBehaviour
{
    [Header("Tilt ID that belongs to this object.")]
    [SerializeField] private TiltID _tiltID;
    [SerializeField] private TiltMove _tiltMoveReference;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("TiltActivator"))
        {
            Debug.Log("Colliding with " + _tiltID);
            switch (_tiltID)
            {
                case TiltID.ForwardTilt:
                    _tiltMoveReference.inputY = 1;
                    break;
                case TiltID.BackwardTilt:
                    _tiltMoveReference.inputY = -1;
                    break;
                case TiltID.LeftTilt:
                    _tiltMoveReference.inputX = -1;
                    break;
                case TiltID.RightTilt:
                    _tiltMoveReference.inputX = 1;
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (_tiltID)
        {
            case TiltID.ForwardTilt or TiltID.BackwardTilt:
                _tiltMoveReference.inputY = 0;
                break;
            case TiltID.LeftTilt or TiltID.RightTilt:
                _tiltMoveReference.inputX = 0;
                break;
        }
    }
}

enum TiltID
{
    ForwardTilt,
    BackwardTilt,
    LeftTilt,
    RightTilt
}