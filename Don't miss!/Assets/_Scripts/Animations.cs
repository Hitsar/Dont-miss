using DG.Tweening;
using TMPro;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] private GameObject _nextButton, _restartButton, _lozeExitButton, _winExitButton;

    [SerializeField] private TextMeshProUGUI _pointText;

    public void LozeMenuAnimatoin()
    {
        _nextButton.transform.DOMoveY(20, 0.7f).SetEase(Ease.OutQuint).OnComplete(() =>
        {
            _nextButton.transform.DOScale(Vector3.one, 0.6f).SetEase(Ease.InOutBack);
        });

        _lozeExitButton.transform.DOMoveY(45, 0.5f).SetDelay(0.6f).SetEase(Ease.OutElastic);
    }

    public void WinMenuAnimatoin()
    {
        _restartButton.transform.DOMoveY(20, 0.7f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            _restartButton.transform.DOScale(Vector3.one, 0.6f).SetEase(Ease.InOutBack);
        });

        _winExitButton.transform.DOMoveY(45, 0.5f).SetDelay(0.6f).SetEase(Ease.OutElastic);
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
