using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour
{
    public Transform[] _waypoints;
    int _cur = 0;

    public float _speed = 0.3f;

    void FixedUpdate()
    {
        // Waypoint not reached yet? then move closer
        if (transform.position != _waypoints[_cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                _waypoints[_cur].position,
                _speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        // Waypoint reached, select next one
        else _cur = (_cur + 1) % _waypoints.Length;
    }
}