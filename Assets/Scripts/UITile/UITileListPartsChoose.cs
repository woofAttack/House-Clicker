using UnityEngine;

public class UITileListPartsChoose<T> : MonoBehaviour where T : Part
{
    [SerializeField] private ListParts<T> _listParts;

    [SerializeField] private GameObject _prefabTilePart;
    [SerializeField] private Transform _transformComponent;

    public void Init(ListParts<T> listParts)
    {
        _listParts = listParts;

        foreach (Part part in listParts)
        {
            GameObject tile = Instantiate<GameObject>(_prefabTilePart, _transformComponent);

            if (tile.TryGetComponent(out UITilePartChoose tilePartChooseComponent))
            {
                tilePartChooseComponent.Init(part);
                tilePartChooseComponent.DrawTile();
            }
        }
    }
}
