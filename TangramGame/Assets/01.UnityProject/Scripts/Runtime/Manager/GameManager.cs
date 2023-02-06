using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GSingleton<GameManager>
{
    public Dictionary<string, GameObject> gameObjs = default;

    public override void Awake()
    {
        base.Awake();


        // 여기서 싱글턴 인스턴스 생성
        Create();
    }   // Awake()

    protected override void Init()
    {
        base.Init();

        // 여기서 게임 매니저가 초기화 된다.
        gameObjs = new Dictionary<string, GameObject>();
    }
}
