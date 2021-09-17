using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MatchingBHandler : MonoBehaviour
{
    LineSpawner spawner;
    bool _matched;

    void Start()
    {
        spawner = GameObject.FindObjectOfType<LineSpawner>();
    }

    public void SetSpawnPointB()
    {
        if (!_matched)
        {
            spawner.SetPointB(transform.Find("Node").position);
            spawner.SetMatchingBHandler(this);
        }
    }

    public void SetMatchedFlag(bool flag)
    {
        _matched = flag;
    }
    public void SetMatchingBText(string name)
    {
        transform.GetComponentInChildren<TextMeshProUGUI>().text = name;
    }
}
