using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEditorInternal;
using Unity.Mathematics;

public class ButtonsManager : MonoBehaviour
{
    public Image imageToZoom;
    public Image imageToScale;
    public Image imageToFade;
    public Image imageToFadeDown;
    public Image imageToFadeUp;
    public Image imageToDrop;
    private bool isZoomOut = false;
    private bool isScaleOut = false;
    private bool isFadeOut = false;
    private bool isDropOut = false;
    public void Zoom()
    {
        float zoomVal = 0;
        float targetZoom = isZoomOut ? 1.0f : zoomVal;
        imageToZoom.transform.DOScale(targetZoom, 0.25f);
        isZoomOut = !isZoomOut;
    }

    public void Scale()
    {
        float scaleVal = 0;
        float targetScale = isScaleOut ? 1.0f : scaleVal;
        imageToScale.DOFade(targetScale, 0.25f);
        isScaleOut = !isScaleOut;
        float zoomVal = 0.9f;
        float targetZoom = isZoomOut ? 1.0f : zoomVal;
        imageToScale.transform.DOScale(targetZoom, 0.25f);
        isZoomOut = !isZoomOut;
    }

    public void Fade()
    {
        float fadeVal = 0;
        float targetFade = isFadeOut ? 1.0f : fadeVal;
        imageToFade.DOFade(targetFade, 0.3f);
        isFadeOut = !isFadeOut;

    }

    public void FadeDown()
    {
        float fadeVal = 0;
        float targetFade = isFadeOut ? 1.0f : fadeVal;
        imageToFadeDown.DOFade(targetFade, 0.3f);
        isFadeOut = !isFadeOut;
        float dropVal = -24.0f;
        float targetDrop = isDropOut ? -22.1f : dropVal;
        imageToFadeDown.transform.DOMoveY(targetDrop, 0.21f);
        isDropOut = !isDropOut;

    }

    public void FadeUp()
    {
        float fadeVal = 0;
        float targetFade = isFadeOut ? 1.0f : fadeVal;
        imageToFadeUp.DOFade(targetFade, 0.3f);
        isFadeOut = !isFadeOut;
        float dropVal = -20.0f;
        float targetDrop = isDropOut ? -22.1f : dropVal;
        imageToFadeUp.transform.DOMoveY(targetDrop, 0.21f);
        isDropOut = !isDropOut;

    }

    public void Drop()
    {
        float dropVal = 0;
        float targetDrop = isDropOut ? -22.1f : dropVal;
        imageToDrop.transform.DOMoveY(targetDrop, 0.2f);
        isDropOut = !isDropOut;
        float zoomVal = 0;
        float targetZoom = isZoomOut ? 1.0f : zoomVal;
        imageToDrop.transform.DOScale(targetZoom, 0.21f);
        isZoomOut = !isZoomOut;
    }
}