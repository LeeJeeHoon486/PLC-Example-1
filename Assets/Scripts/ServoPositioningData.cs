using UnityEngine;
using System.Collections.Generic;



//1.동작패턴
public enum OperationPattern
{
    End,        //지정된 위치로 이동한 뒤, 해당 스텝을 완전히 종료.
    Continue,   //지정된 위치로 이동한 뒤, 멈추지 않고 다음 스텝의 목표속도로 변속하면 스텝을 다음 스텝으로 전환.
    Locate      //지정된 위치로 이동한 뒤, 멈추고 Dwell 시간동안 정지후에 다음 스텝으로 전환.
}

//2.제어방식
public enum ControlMethod
{
    ABS_Linear,
    INC_Linear,
    Forward_Speed,
    Reverse_Speed
}
[System.Serializable]

public struct PositioningData
{
    public OperationPattern pattern;
    public ControlMethod method;
    public float positioningAddress;
    public float commandSpeed;
    public float dwellTime;
    public ushort mCode;
}
[System.Serializable]

public class AxisData
{
    public string axisName = "new Axis";
    public List<PositionData> stepDataList = new List<PositionData>();
}

[CreateAssetMenu(fileName = "new PositioningData", menuName = "DigitalTwin/PositioningData")]

public class ServoPositioningData : ScriptableObject
{
    public List<AxisData> axes  = new List<AxisData>();
}
