using Orchard.UI.Resources;

namespace MetroUI
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest
                .DefineScript("jQCloud")
                .SetUrl("jqcloud/jqcloud.min.js", "jqcloud/jqcloud.js")
                .SetDependencies("jQuery");

            manifest
                .DefineStyle("jQCloud")
                .SetUrl("jqcloud/jqcloud.min.css", "jqcloud/jqcloud.css");
        }
    }
}