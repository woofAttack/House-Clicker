using UnityEngine;

public class BuildBehaviour
{
    public void SetPartToBuild(Part.PartInfo info) { Debug.LogFormat("Ou mai, it is {0}, right?", info.Name); }
}