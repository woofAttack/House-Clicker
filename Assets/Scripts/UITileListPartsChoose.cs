using UnityEngine;

public class UITileListPartsChoose<T> : MonoBehaviour where T : Part
{
    private ListParts<T> _listParts;
    private GameObject _prefabTilePart;
    private Transform _transformComponent;
    public void Init(ListParts<T> listParts, GameObject prefabTilePart)
    {
        _listParts = listParts;
        _prefabTilePart = prefabTilePart;

        _transformComponent = transform;

        foreach (Part part in listParts)
        {
            Instantiate<GameObject>(prefabTilePart, _transformComponent);
        }
    }
}
