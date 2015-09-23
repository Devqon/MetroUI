using Orchard.ContentManagement;

namespace MetroUI.Models
{
    public class MetroThemeSettingsPart : ContentPart
    {
        public string NavigationColor {
            get { return this.Retrieve(r => r.NavigationColor); }
            set { this.Store(r => r.NavigationColor, value); }
        }

        public bool FixedHeader {
            get { return this.Retrieve(r => r.FixedHeader); }
            set { this.Store(r => r.FixedHeader, value); }
        }

        public bool DarkBreadcrumbs {
            get { return this.Retrieve(r => r.DarkBreadcrumbs); }
            set { this.Store(r => r.DarkBreadcrumbs, value); }
        }

        public string BreadcrumbSize {
            get { return this.Retrieve(r => r.BreadcrumbSize); }
            set { this.Store(r => r.BreadcrumbSize, value); }
        }

        public string BreadcrumbMode {
            get { return this.Retrieve(r => r.BreadcrumbMode); }
            set { this.Store(r => r.BreadcrumbMode, value); }
        }
    }
}