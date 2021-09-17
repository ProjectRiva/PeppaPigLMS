using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAnimator : MonoBehaviour
{
    [SerializeField] float _animationDuration = 5f;
    LineRenderer _line;
    Vector3 _pointA;
    Vector3 _pointB;
    float _interpolation = 0;
    Vector3 _lineDrawerPosition;
    bool _initialPositionSet;
    void Start()
    {
        _line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (!_initialPositionSet)
        {
            _line.SetPosition(0, _pointA);
            _initialPositionSet = true;
        }

        if (_pointA != Vector3.zero && _pointB != Vector3.zero)
        {
            if (_lineDrawerPosition != _pointB)
            {
                _interpolation += Time.deltaTime;
                _lineDrawerPosition = Vector3.Lerp(_pointA, _pointB, _interpolation / _animationDuration);
                _line.SetPosition(1, _lineDrawerPosition);
            }
            else
            {
                Destroy(this);
            }
        }
    }

    public void SetPointA(Vector3 pos)
    {
        _pointA = pos;
        _lineDrawerPosition = _pointA;
    }

    public void SetPointB(Vector3 pos)
    {
        _pointB = pos;
    }
}
