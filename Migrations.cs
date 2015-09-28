using Orchard.ContentManagement.MetaData;
using Orchard.Core.Navigation.Models;
using Orchard.Data.Migration;

namespace MetroUI
{
    public class Migrations : DataMigrationImpl
    {
        public int Create() {

            ContentDefinitionManager.AlterPartDefinition(typeof (MenuWidgetPart).Name, part => part
                .WithField("MenuMode", field => field
                    .WithDisplayName("Menu Mode")
                    .OfType("EnumerationField")
                    .WithSetting("EnumerationFieldSettings.Options", 
                        string.Join(System.Environment.NewLine,
                            new [] {"Default", "Vertical", "MMenu", "FMenu", "HMenu", "TMenu", "VMenu", "DMenu"}))
                    .WithSetting("EnumerationFieldSettings.Hint", string.Format("The menu mode, see {0} for the available modes", "<a href=\"http://metroui.org.ua/menu.html\">menu modes</a>")))
                            
                .WithField("MenuSize", field => field
                    .WithDisplayName("Menu Size")
                    .OfType("EnumerationField")
                    .WithSetting("EnumerationFieldSettings.Options",
                        string.Join(System.Environment.NewLine,
                            new [] {"Normal", "Compact"}))));

            return 1;
        }
    }
}