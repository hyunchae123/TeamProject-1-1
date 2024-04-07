using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class FieldMonster : Enemy
{
    public FieldMonster()
    {
        EnemyPower = 3;
        moveSpeed = 4.0f;
        EXP = 20;
        strunTime = 0.0f;
    }
}
