using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UIElements;

public class Restarting : MonoBehaviour
{
    [SerializeField] public GameObject RedGhost;
    [SerializeField] public GameObject PinkGhost;
    [SerializeField] public GameObject BlueGhost;
    [SerializeField] public GameObject OrangeGhost;
    [SerializeField] public GameObject Character;

    [SerializeField] public GameObject _redGhostTransform;
    [SerializeField] public GameObject _pinkGhostTransform;
    [SerializeField] public GameObject _blueGhostTransform;
    [SerializeField] public GameObject _orangeGhostTransform;
    [SerializeField] public GameObject _characterGhostTransform;

    [SerializeField] public OrangeGhostAiMovement OrangeGhostMovement;
    void Start()
    {
        _redGhostTransform.transform.position = RedGhost.transform.position;
        _pinkGhostTransform.transform.position = PinkGhost.transform.position;
        _blueGhostTransform.transform.position = BlueGhost.transform.position;
        _orangeGhostTransform.transform.position = OrangeGhost.transform.position;
        _characterGhostTransform.transform.position = Character.transform.position;
    }

    public void Restart()
    {
        RedGhost.transform.position = _redGhostTransform.transform.position;
        PinkGhost.transform.position = _pinkGhostTransform.transform.position;
        BlueGhost.transform.position = _blueGhostTransform.transform.position;
        OrangeGhost.transform.position = _orangeGhostTransform.transform.position;
        OrangeGhostMovement.currentWaypoint = 0;
        Character.transform.position = _characterGhostTransform.transform.position;
    }
}
