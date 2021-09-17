using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MatchingAHandler : MonoBehaviour
{
    LineSpawner spawner;
    bool _matched;

    void Start()
    {
        spawner = GameObject.FindObjectOfType<LineSpawner>();
    }

    public void SetSpawnPointA()
    {
        if (!_matched)
        {
            spawner.SetPointA(transform.Find("Node").position);
            spawner.SetMatchingAHandler(this);
        }
    }

    public void SetMatchedFlag(bool flag)
    {
        _matched = flag;
    }

    public void SetMatchingAText(string name)
    {
        transform.GetComponentInChildren<TextMeshProUGUI>().text = name;
    }
}
