# 腾讯OCR活动包

[腾讯云](https://cloud.tencent.com/product/ocr-catalog)提供多种OCR，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程。本代码库基于[云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)开发，打通UiPath和腾讯OCR，让开发者能在UiPath Studio中通过简单的拖放和设置把腾讯OCR用到相关流程中，从而加速开发过程。

## 快速开始

在UiPath Studio中使用百度OCR活动包可以遵循以下步骤：
1. **创建项目**：使用[templates/CloudOcrBasicProcess](https://github.com/allenlooplee/CloudOcrActivitiesPack/tree/master/templates/CloudOcrBasicProcess)模版创建OCR流程，你可以查阅[它的文档](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/cloud-ocr-basic-process.md)。
2. **安装活动包**：在GitHub Releases中下载[v0.1.0 pre-release](https://github.com/allenlooplee/TencentOcrActivitiesPack/releases/tag/v0.1.0)，并在UiPath Studio的Manage Packages中安装。
3. **配置密钥**：在腾讯云上开通OCR服务，并把SecretId和SecretKey保存到[config/tencent_ocr_config.xlsx](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/templates/CloudOcrBasicProcess/config/tencent_ocr_config.xlsx)。
4. **加载密钥**: 使用[snippets/LoadTencentOcrConfig.xaml](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/snippets/LoadTencentOcrConfig.xaml)代码片段从上述配置文件加载密钥和地域参数。
5. **使用活动**：把你想使用的OCR活动从Activities面板拖到OCR Scope活动中。

## 其他代码库和参考资料
* [云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)
* [腾讯OCR API文档](https://cloud.tencent.com/document/api/866/33515)
* [Tencent Cloud API 3.0 SDK for .NET](https://github.com/TencentCloud/tencentcloud-sdk-dotnet)
* [JSON.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [How to Create Activities](https://docs.uipath.com/integrations/docs/how-to-create-activities)
* [Testing Framework for UiPath](https://connect.uipath.com/marketplace/components/uipath-testing-framework)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/TencentOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并非官方出品，不存在官方支持。
* 本活动包并不包含任何本地模型，你的票据将会发往腾讯云进行文字识别。
* 本活动包并不收取任何费用，腾讯云可能[根据你的使用情况收取费用](https://cloud.tencent.com/product/ocr-catalog/pricing)。
