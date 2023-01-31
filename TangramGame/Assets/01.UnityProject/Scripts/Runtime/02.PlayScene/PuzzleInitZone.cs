using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleInitZone : MonoBehaviour
{
    public Canvas parentCanves = default;


    // Start is called before the first frame update
    void Start()
    {
        GFunc.Assert(parentCanves != null || parentCanves != default);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
