# 腾讯OCR活动包

![海报](https://github.com/allenlooplee/TencentOcrActivitiesPack/blob/master/docs/images/poster.png)

[腾讯云](https://cloud.tencent.com/product/ocr-catalog)提供多种OCR，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程。本代码库基于[云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)开发，打通UiPath和腾讯OCR，让开发者能在UiPath Studio中通过简单的拖放和设置把腾讯OCR用到相关流程中，从而加速开发过程。

## 快速开始

在UiPath Studio中使用百度OCR活动包可以遵循以下步骤：
1. **创建项目**：使用[templates/CloudOcrBasicProcess](https://github.com/allenlooplee/CloudOcrActivitiesPack/tree/master/templates/CloudOcrBasicProcess)模版创建OCR流程，你可以查阅[它的文档](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/cloud-ocr-basic-process.md)。
2. **安装活动包**：打开UiPath Studio的Manage Packages，在[nuget.org](https://api.nuget.org/v3/index.json)中搜索并安装Tencent.Ocr.Activities。
3. **配置密钥**：在腾讯云上开通OCR服务，并把SecretId和SecretKey保存到[config/tencent_ocr_config.xlsx](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/templates/CloudOcrBasicProcess/config/tencent_ocr_config.xlsx)。
4. **加载密钥**: 使用[snippets/LoadTencentOcrConfig.xaml](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/snippets/LoadTencentOcrConfig.xaml)代码片段从上述配置文件加载密钥和地域参数。
5. **使用活动**：把你想使用的OCR活动从Activities面板拖到OCR Scope活动中。

## OCR活动清单

本活动包支持以下[云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)的OCR活动：

#|名称|类型|活动
---|---|---|---
1|[增值税发票识别](https://cloud.tencent.com/document/product/866/36210)|票据|[VatInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VatInvoiceActivity.cs)
2|[定额发票识别](https://cloud.tencent.com/document/product/866/37073)|票据|[QuotaInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/QuotaInvoiceActivity.cs)
3|[出租车票识别](https://cloud.tencent.com/document/product/866/37072)|票据|[TaxiReceiptActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaxiReceiptActivity.cs)
4|[火车票识别](https://cloud.tencent.com/document/product/866/37071)|票据|[TrainTicketActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TrainTicketActivity.cs)
5|[身份证识别](https://cloud.tencent.com/document/product/866/33524)|卡证|[IdCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/IdCardActivity.cs)
6|[户口本识别](https://cloud.tencent.com/document/product/866/40036)|卡证|[HouseholdRegisterActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HouseholdRegisterActivity.cs)
7|[护照识别](https://cloud.tencent.com/document/product/866/37840)|卡证|[PassportActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/PassportActivity.cs)
8|[港澳通行证识别](https://cloud.tencent.com/document/product/866/37074)|卡证|[HkMacauExitentrypermitActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HkMacauExitentrypermitActivity.cs)
9|[台湾通行证识别](https://cloud.tencent.com/document/product/866/37074)|卡证|[TaiwanExitentrypermitActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaiwanExitentrypermitActivity.cs)
10|[营业执照识别](https://cloud.tencent.com/document/product/866/36215)|卡证|[BusinessLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BusinessLicenseActivity.cs)
11|[银行卡识别](https://cloud.tencent.com/document/product/866/36216)|卡证|[BankCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BankCardActivity.cs)
12|[行驶证识别](https://cloud.tencent.com/document/product/866/36209)|汽车场景|[VehicleLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleLicenseActivity.cs)
13|[驾驶证识别](https://cloud.tencent.com/document/product/866/36213)|汽车场景|[DriverLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/DriverLicenseActivity.cs)
14|[机动车销售发票识别](https://cloud.tencent.com/document/product/866/37076)|票据|[VehicleInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleInvoiceActivity.cs)

## 其他代码库和参考资料
* [云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)
* [腾讯OCR API文档](https://cloud.tencent.com/document/api/866/33515)
* [Tencent Cloud API 3.0 SDK for .NET](https://github.com/TencentCloud/tencentcloud-sdk-dotnet)
* [JSON.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [How to Create Activities](https://docs.uipath.com/integrations/docs/how-to-create-activities)
* [Testing Framework for UiPath](https://connect.uipath.com/marketplace/components/uipath-testing-framework)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)
* [RPA开发与应用](https://github.com/allenlooplee/RPABook)

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/TencentOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并非官方出品，不存在官方支持。
* 本活动包并不包含任何本地模型，你的票据将会发往腾讯云进行文字识别。
* 本活动包并不收取任何费用，腾讯云可能[根据你的使用情况收取费用](https://cloud.tencent.com/product/ocr-catalog/pricing)。
