using System.Linq;
using Orchard.Core.Navigation.Models;
using Orchard.DisplayManagement.Implementation;

namespace MetroUI
{
    public class MenuAlternatesFactory : ShapeDisplayEvents
    {
        public override void Displaying(ShapeDisplayingContext context) {
            context.ShapeMetadata.OnDisplaying(displayedContext => {

                var contentPart = displayedContext.Shape.ContentPart;
                if (contentPart == null) return;

                var menuWidgetPart = contentPart as MenuWidgetPart;
                if (menuWidgetPart == null) return;

                var menuModeField = menuWidgetPart.Fields.FirstOrDefault(f => f.Name == "MenuMode" && f.FieldDefinition.Name == "EnumerationField");
                if (menuModeField == null) return;

                var menuSizeField = menuWidgetPart.Fields.FirstOrDefault(f => f.Name == "MenuSize");
                string menuSize = menuSizeField != null ? ((dynamic) menuSizeField).Value : string.Empty;

                string menuMode = ((dynamic) menuModeField).Value;
                if (!string.IsNullOrEmpty(menuMode)) {
                    displayedContext.ShapeMetadata.Alternates.Add(
                        // MenuWidget_{MenuMode}
                        string.Format("{0}__{1}", displayedContext.ShapeMetadata.Type, menuMode));
                }
                if (!string.IsNullOrEmpty(menuSize)) {
                    displayedContext.Shape.MenuSize = menuSize;
                }
            });
        }
    }
}