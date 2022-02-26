using UnityEngine;

namespace Simple.Ux.Data.Unity {

  /// <summary>
  /// Represents a custom unity UI element
  /// </summary>
  public class UnityUIElement : IUxViewElement {

    ///<summary><inheritdoc/></summary>
    public View View {
      get;
      internal set;
    }

    /// <summary>
    /// The rect-transform of the UI element this controls.
    /// </summary>
    public RectTransform RectTransform {
      get;
    }

    public UnityUIElement(RectTransform UIElement) {
      RectTransform = UIElement;
      UIElement.gameObject.SetActive(false);
    }

    public IUxViewElement Copy(View toNewView = null)
      => new UnityUIElement(GameObject.Instantiate<RectTransform>(RectTransform));
  }
}