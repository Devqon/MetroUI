using MetroUI.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace MetroUI.Handlers
{
    public class MetroThemeSettingsPartHandler : ContentHandler
    {
        public MetroThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<MetroThemeSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<MetroThemeSettingsPart>("MetroThemeSettings", "Parts/MetroThemeSettings", "MetroUI"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;

            base.GetItemMetadata(context);

            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("MetroUI")));
        }
    }
}