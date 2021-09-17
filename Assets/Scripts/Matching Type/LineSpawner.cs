using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawner : MonoBehaviour
{
    public GameObject line;
    Vector3 _pointA;
    Vector3 _pointB;
    bool _spawned;
    MatchingAHandler _handlerA;
    MatchingBHandler _handlerB;

    private void Update()
    {
        if (_pointA != Vector3.zero && _pointB != Vector3.zero)
        {
            GameObject spawnedLine = Instantiate(line, Vector3.zero, Quaternion.identity);
            LineAnimator lineAnim = spawnedLine.GetComponent<LineAnimator>();
            lineAnim.SetPointA(_pointA);
            lineAnim.SetPointB(_pointB);
            _spawned = true;
            if (_spawned)
            {
                _pointA = Vector3.zero;
                _pointB = Vector3.zero;
                _handlerA.SetMatchedFlag(true);
                _handlerB.SetMatchedFlag(true);
                _spawned = false;
            }
        }
    }

    public void SetPointA(Vector3 pos)
    {
        _pointA = pos;
    }

    public void SetPointB(Vector3 pos)
    {
        _pointB = pos;
    }

    public void SetMatchingAHandler(MatchingAHandler handler)
    {
        _handlerA = handler;
    }

    public void SetMatchingBHandler(MatchingBHandler handler)
    {
        _handlerB = handler;
    }
}
