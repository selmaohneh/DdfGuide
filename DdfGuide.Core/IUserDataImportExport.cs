using System;

namespace DdfGuide.Core
{
    public interface IUserDataImportExport
    {
        void ExportUserData();
        void ImportUserData();
        event EventHandler UserDataImported;
    }
}