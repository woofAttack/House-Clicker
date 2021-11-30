using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UITilePartChoose : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image _imageComponent;
    [SerializeField] private Text _textComponent;

    private Part _part;
    private BuildBehaviour _buildBehaviour = new BuildBehaviour();

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
        
        _buildBehaviour.SetPartToBuild(_part.Info());
    }
}
