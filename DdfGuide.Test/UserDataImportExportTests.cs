using System;
using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;
using Newtonsoft.Json;

namespace DdfGuide.Test
{
    [TestClass]
    public class UserDataImportExportTests
    {
        [TestMethod]
        public void ExportUserData()
        {
            var mocker = new AutoMocker();

            var userData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(Guid.Empty, true, false),
                new AudioDramaUserData(Guid.Empty, false, true),
            };

            mocker
                .GetMock<ICache<IEnumerable<AudioDramaUserData>>>()
                .Setup(x => x.Load())
                .Returns(userData);

            var sut = mocker.CreateInstance<UserDataImportExport>();

            sut.ExportUserData();

            mocker.Verify<ICache<IEnumerable<AudioDramaUserData>>>(x => x.Load(), Times.Once);

            var json = JsonConvert.SerializeObject(userData);
            mocker.Verify<IClipboardService>(x => x.SetClipboardText(json), Times.Once);
        }
    }
}
