using UnityEngine;

public abstract class Part
{
    private string _name;
    private Sprite _sprite;

    public Part(PrefabBlock prefabBlock)
    {
        _name = prefabBlock.Name;
        _sprite = prefabBlock.Sprite;
    }

    public PartInfo Info() => new PartInfo(this);

    public class PartInfo
    {
        public readonly string Name;
        public readonly Sprite Sprite;

        public PartInfo(Part part)
        {
            Name = part._name;
            Sprite = part._sprite;
        }
    }
}

public class Block : Part
{
    public Block(PrefabBlock prefabBlock) : base(prefabBlock)
    {
    }
}

