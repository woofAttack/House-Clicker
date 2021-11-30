using System.Collections.Generic;

public class NewDataInitializerBlock : InitializerParts<Block>
{
    private List<Block> _parts = new List<Block>();
    private List<PrefabBlock> _listPrefabs;

    public NewDataInitializerBlock(ListPrefabsBlock listPrefabs)
    {
        _listPrefabs = listPrefabs.prefabBlocks;
    }

    private protected override void CreateArrayParts()
    {
        for (int i = 0, imax = _listPrefabs.Count; i < imax; i++)
        {
            _parts.Add(new Block(_listPrefabs[i]));
        }
    }

    private protected override List<Block> ArrayParts() => _parts;
}
