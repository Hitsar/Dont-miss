using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnimations : MonoBehaviour
{
    [SerializeField] private GameObject _startButton, _recordText;

    [SerializeField] private Image _startButtonImage;

    private void Start()
    {
        _startButton.transform.DOLocalMoveY(45, 0.8f).SetEase(Ease.OutElastic);
        _startButtonImage.DOFade(1, 0.6f).SetEase(Ease.OutCubic);

        _recordText.transform.DOLocalMoveY(-125, 0.5f).SetDelay(0.2f).OnComplete(() =>
        {
            _recordText.transform.DOScale(Vector2.one, 0.5f).SetEase(Ease.InOutCubic);
        });
    }
}
