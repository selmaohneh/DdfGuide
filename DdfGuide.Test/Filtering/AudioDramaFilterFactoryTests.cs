using System;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class AudioDramaFilterFactoryTests
    {
        [TestMethod]
        public void TheFactoryCanCreateATypeForEveryFilteRMode()
        {
            var filterFactory = new AudioDramaFilterFactory();
            var filterModes = Enum.GetValues(typeof(EAudioDramaFilterMode));

            foreach (EAudioDramaFilterMode filterMode in filterModes)
            {
                try
                {
                    filterFactory.Create(filterMode);
                }
                catch (Exception)
                {
                    Assert.Fail($"Can't create a filter for mode {filterMode}");
                }
            }
        }
    }
}