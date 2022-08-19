﻿using CMS.DocumentEngine;
using KX12To13Converter.PortalEngineToPageBuilder.EventArgs;

namespace KX12To13Converter.Interfaces
{
    public interface IConversionProcessingMethods
    {
        bool HandleProcessOnly(TreeNode document, PortalToMVCProcessDocumentPrimaryEventArgs results);
        bool HandleProcessAndSaveDocument(TreeNode document, PortalToMVCProcessDocumentPrimaryEventArgs results);
        bool HandleProcessAndSendDocument(TreeNode document, PortalToMVCProcessDocumentPrimaryEventArgs results);
        bool SendDocument(TreeNode document, PageBuilderConversionsInfo pageBuilderConversionsInfo);
        bool SendDocument(PageBuilderConversionsInfo pageBuilderConversionsInfo);
        bool ReProcesses(PageBuilderConversionsInfo pageBuilderConversionsInfo);
    }
}
