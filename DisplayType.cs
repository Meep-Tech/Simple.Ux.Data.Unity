using Meep.Tech.Collections.Generic;
using System;
using System.Collections.Generic;

namespace Simple.Ux.Data.Unity {

  /// <summary>
  /// Unity specific display types.
  /// </summary>
  public class DisplayType : DataField.DisplayType {

    /// <summary>
    /// Used to pick colors
    /// </summary>
    public static DisplayType ColorPicker {
      get;
    } = new DisplayType(nameof(ColorPicker), (
         string title,
         string tooltip,
         object value,
         bool isReadOnly,
         string dataKey,
         DelegateCollection<Func<DataField, View, bool>> enabledIf,
         DelegateCollection<Func<DataField, View, bool>> hiddenIf,
         DelegateCollection<Func<DataField, object, (bool success, string message)>> validations,
         DelegateCollection<Action<DataField, object>> onValueChanged,
         Dictionary<Type, Attribute> attributes
       ) => {
         throw new NotImplementedException();
       }, typeof(UnityEngine.Color).AsSingleItemEnumerable());

    /// <summary>
    /// Used to display images
    /// </summary>
    public static DisplayType Image {
      get;
    } = new DisplayType(nameof(Image), (
         string title,
         string tooltip,
         object value,
         bool isReadOnly,
         string dataKey,
         DelegateCollection<Func<DataField, View, bool>> enabledIf,
         DelegateCollection<Func<DataField, View, bool>> hiddenIf,
         DelegateCollection<Func<DataField, object, (bool success, string message)>> validations,
         DelegateCollection<Action<DataField, object>> onValueChanged,
         Dictionary<Type, Attribute> attributes
       ) => {

         throw new NotImplementedException();
       }, typeof(UnityEngine.UI.Image).AsSingleItemEnumerable());

    /// <summary>
    /// Make a new display type
    /// </summary>
    internal DisplayType(string nameId, DefaultFieldConstructor defaultFieldConstructor, IEnumerable<System.Type> defaultFieldTypes = null)
      : base(nameId, defaultFieldConstructor, defaultFieldTypes) { }
  }
}