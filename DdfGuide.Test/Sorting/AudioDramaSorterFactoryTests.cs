using System;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class AudioDramaSorterFactoryTests
    {
        [TestMethod]
        public void TheFactoryCanCreateATypeForEverySortMode()
        {
            var sorterFactory = new AudioDramaSorterFactory();
            var sortModes = Enum.GetValues(typeof(EAudioDramaSortMode));

            foreach (EAudioDramaSortMode sortMode in sortModes)
            {
                try
                {
                    sorterFactory.Create(sortMode);
                }
                catch (Exception)
                {
                    Assert.Fail($"Can't create a sorter for mode {sortMode}");
                }
            }
        }
    }
}
