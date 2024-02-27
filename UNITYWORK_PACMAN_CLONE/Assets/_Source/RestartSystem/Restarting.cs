using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UIElements;

public class Restarting : MonoBehaviour
{
    [SerializeField] public GameObject RedGhost;
    [SerializeField] public GameObject PinkGhost;
    [SerializeField] public GameObject BlueGhost;
    [SerializeField] public GameObject OrangeGhost;
    [SerializeField] public GameObject Character;
    public Transform _redGhostTransform { private get; set; }
    public Transform _pinkGhostTransform { private get; set; }
    public Transform _blueGhostTransform { private get; set; }
    public Transform _orangeGhostTransform { private get; set; }
    public Transform _characterGhostTransform { private get; set; }
    void Start()
    {
        _redGhostTransform.position = RedGhost.transform.position;
        _pinkGhostTransform.position = PinkGhost.transform.position;
        _blueGhostTransform.position = BlueGhost.transform.position;
        _orangeGhostTransform.position = OrangeGhost.transform.position;
        _characterGhostTransform.position = Character.transform.position;
    }

    public void Restart()
    {
        RedGhost.transform.position = _redGhostTransform.position;
        PinkGhost.transform.position = _pinkGhostTransform.position;
        BlueGhost.transform.position = _blueGhostTransform.position;
        OrangeGhost.transform.position = _orangeGhostTransform.position;
        Character.transform.position = _characterGhostTransform.position;
    }
}
