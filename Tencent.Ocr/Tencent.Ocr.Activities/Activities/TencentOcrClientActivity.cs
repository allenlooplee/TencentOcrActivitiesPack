using Cloud.Ocr.Contracts;
using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Tencent.Ocr.Activities.Properties;
using Tencent.Ocr.Models;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Tencent.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.TencentOcrClientActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.TencentOcrClientActivity_Description))]
    public class TencentOcrClientActivity : BaseOcrClientActivity
    {
        #region Properties

        [LocalizedDisplayName(nameof(Resources.TencentOcrClientActivity_SecretId_DisplayName))]
        [LocalizedDescription(nameof(Resources.TencentOcrClientActivity_SecretId_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> SecretId { get; set; }

        [LocalizedDisplayName(nameof(Resources.TencentOcrClientActivity_SecretKey_DisplayName))]
        [LocalizedDescription(nameof(Resources.TencentOcrClientActivity_SecretKey_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> SecretKey { get; set; }

        [LocalizedDisplayName(nameof(Resources.TencentOcrClientActivity_Region_DisplayName))]
        [LocalizedDescription(nameof(Resources.TencentOcrClientActivity_Region_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Region { get; set; }

        #endregion

        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (SecretId == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(SecretId)));
            if (SecretKey == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(SecretKey)));
            if (Region == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(Region)));

            base.CacheMetadata(metadata);
        }

        protected override IOcrClient GetOcrClient(AsyncCodeActivityContext context)
        {
            var secretId = SecretId.Get(context);
            var secretKey = SecretKey.Get(context);
            var region = Region.Get(context);

            return new TencentOcrClient(secretId, secretKey, region);
        }

        #endregion
    }
}

