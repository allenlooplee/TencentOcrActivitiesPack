using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using Tencent.Ocr.Activities.Design.Designers;
using Tencent.Ocr.Activities.Design.Properties;

namespace Tencent.Ocr.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(TencentOcrClientActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(TencentOcrClientActivity), new DesignerAttribute(typeof(TencentOcrClientActivityDesigner)));
            builder.AddCustomAttributes(typeof(TencentOcrClientActivity), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
