using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_2_9 : MiniGameBase
{
    protected override float TimerDuration => 5f;
    protected override string MinigameExplain => "쌓아라!";

    public override void StartGame()
    {


        // 추가 초기화
        // 예: instructionText.text = MinigameExplain;
    }

    public void Succeed()
    {
        Success();
    }
    public void Failure()
    {
        Fail();
    }
}
