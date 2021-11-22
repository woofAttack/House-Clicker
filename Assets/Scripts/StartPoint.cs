using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StartPoint : MonoBehaviour
{
    [SerializeField] private GameObject _UITileListChooseBlock;
    [SerializeField] private GameObject _prefabTilePart;
    [SerializeField] private GameObject _UITileListChooseRoof;
    [SerializeField] private GameObject _UITileListChooseField;

    public void Awake()
    {
        InitializerParts<Block> initializerBlock = new NewDataInitializerParts<Block>();
        ListParts<Block> listBlock = initializerBlock.Result();

        _UITileListChooseBlock.AddComponent<UITileListPartsChoose<Block>>().Init(listBlock, _prefabTilePart);
    }


}



public class ListPartChoose<T>  where T : Part
{

}

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

public class UITilePartChoose : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image _imageComponent;
    [SerializeField] private Text _textComponent;

    private Part _part;
    private BuildBehaviour _buildBehaviour;

    public void Init(Part part) 
    {
        _part = part;
    }

    public void DrawTile()
    {
        Part.PartInfo partInfo = _part.Info();

        _imageComponent.sprite = partInfo.Sprite;
        _textComponent.text = partInfo.Name;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _buildBehaviour.SetPartToBuild();
    }
}

public class BuildBehaviour
{
    public void SetPartToBuild() { }
}