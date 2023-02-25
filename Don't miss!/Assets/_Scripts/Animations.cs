using DG.Tweening;
using TMPro;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] private GameObject _nextButton, _restartButton, _lozeExitButton, _winExitButton;

    [SerializeField] private TextMeshProUGUI _pointText;

    private Vector2 _startPosition = new Vector2(0, 310);
    private Vector2 _exitStartPosition = new Vector2(0, -260);

    public void LozeMenuAnimatoin()
    {
        _restartButton.transform.localPosition = _startPosition;
        _lozeExitButton.transform.localPosition = _exitStartPosition;

        _restartButton.transform.DOLocalMoveY(25, 0.8f).SetEase(Ease.OutQuint).OnComplete(() =>
        {
            _restartButton.transform.DOScale(Vector3.one, 0.6f).SetEase(Ease.InOutBack);
        });
        _lozeExitButton.transform.DOLocalMoveY(-140, 0.5f).SetDelay(0.8f).SetEase(Ease.OutElastic);
    }

    public void WinMenuAnimatoin()
    {
        _nextButton.transform.localPosition = _startPosition;
        _winExitButton.transform.localPosition = _exitStartPosition;

        _nextButton.transform.DOLocalMoveY(25, 0.8f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            _nextButton.transform.DOScale(Vector3.one, 0.6f).SetEase(Ease.InOutBack);
        });
        _winExitButton.transform.DOLocalMoveY(-140, 0.5f).SetDelay(0.8f).SetEase(Ease.OutElastic);
    }

    public void TextAnimation()
    {
        _pointText.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        _pointText.transform.DOScale(Vector3.one, 0.7f).SetEase(Ease.OutBack);
        _pointText.DOColor(Color.green, 0.3f).OnComplete(() =>
        {
            _pointText.DOColor(Color.white, 0.3f);
        });
    }
}
