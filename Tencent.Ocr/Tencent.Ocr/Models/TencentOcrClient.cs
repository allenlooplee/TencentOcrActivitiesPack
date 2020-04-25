using Cloud.Ocr.Contracts;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Ocr.V20181119;
using TencentCloud.Ocr.V20181119.Models;
using System.IO;
using Cloud.Ocr.Models;

namespace Tencent.Ocr.Models
{
    public class TencentOcrClient : IOcrClient
    {
        public TencentOcrClient(string secretId, string secretKey, string region)
        {
            Name = "Tencent OCR";

            _actionDictionary = BuildActionDictionary();

            var credential = new Credential
            {
                SecretId = secretId,
                SecretKey = secretKey
            };

            var httpProfile = new HttpProfile
            {
                Endpoint = "ocr.tencentcloudapi.com"
            };

            var clientProfile = new ClientProfile
            {
                HttpProfile = httpProfile,
                SignMethod = "TC3-HMAC-SHA256"
            };

            _tencentOcrClient = new OcrClient(credential, region, clientProfile);
        }

        public string Name { get; }

        public async Task<JObject> RecognizeAsync(string recognizerName, string imagePath, Dictionary<string, object> options = null)
        {
            // Load image data as base-64 string
            var imageData = File.ReadAllBytes(imagePath);
            var imageBase64 = Convert.ToBase64String(imageData);

            // Translate the recognizer name used by OCR activity to the action name used by Tencent OCR
            var actionName = _actionDictionary[recognizerName];

            // Create request object for specified recognizer via reflection
            var requestTypeName = $"TencentCloud.Ocr.V20181119.Models.{actionName}Request";
            var ocrClientType = typeof(OcrClient);
            var ocrClientAssembly = ocrClientType.Assembly;
            var requestType = ocrClientAssembly.GetType(requestTypeName);
            var request = Activator.CreateInstance(requestType);

            // Set image property via reflection
            var imagePropertyName = "ImageBase64";
            var imagePropertyInfo = requestType.GetProperty(imagePropertyName);
            imagePropertyInfo.SetValue(request, imageBase64);

            // Call OCR method via reflection
            var methodName = $"{actionName}Sync";
            var methodInfo = ocrClientType.GetMethod(methodName);
            var response = await Task.Run(() => methodInfo.Invoke(_tencentOcrClient, new[] { request }));

            // Return response as JObject
            return JObject.FromObject(response);
        }

        private Dictionary<string, string> BuildActionDictionary()
        {
            return new Dictionary<string, string>
            {
                [RecognizerNames.VatInvoice] = nameof(_tencentOcrClient.VatInvoiceOCR),
                [RecognizerNames.BankCard] = nameof(_tencentOcrClient.BankCardOCR),
                [RecognizerNames.BusinessLicense] = nameof(_tencentOcrClient.BizLicenseOCR),
                [RecognizerNames.IdCard] = nameof(_tencentOcrClient.IDCardOCR),
                [RecognizerNames.TaxiReceipt] = nameof(_tencentOcrClient.TaxiInvoiceOCR),
                [RecognizerNames.TrainTicket] = nameof(_tencentOcrClient.TrainTicketOCR),
                [RecognizerNames.QuotaInvoice] = nameof(_tencentOcrClient.QuotaInvoiceOCR),
                [RecognizerNames.HouseholdRegister] = nameof(_tencentOcrClient.ResidenceBookletOCR),
                [RecognizerNames.Passport] = nameof(_tencentOcrClient.PassportOCR),
                [RecognizerNames.HkMacauExitentrypermit] = nameof(_tencentOcrClient.PermitOCR),
                [RecognizerNames.TaiwanExitentrypermit] = nameof(_tencentOcrClient.PermitOCR),
                [RecognizerNames.DriverLicense] = nameof(_tencentOcrClient.DriverLicenseOCR),
                [RecognizerNames.VehicleLicense] = nameof(_tencentOcrClient.VehicleLicenseOCR),
                [RecognizerNames.VehicleInvoice] = nameof(_tencentOcrClient.CarInvoiceOCR)
            };
        }

        private OcrClient _tencentOcrClient;
        private Dictionary<string, string> _actionDictionary;
    }
}
