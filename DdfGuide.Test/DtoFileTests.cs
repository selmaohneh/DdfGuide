using System.Collections.Generic;
using System.IO;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DdfGuide.Test
{
    [TestClass]
    public class DtoFileTests
    {
        [TestMethod]
        public void DtoFileContainsNoDuplicateIds()
        {
            var json = File.ReadAllText("../../../dtos.json");
            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);

            var duplicates = dtos.GroupBy(x => x.Id).Where(x => x.Count() > 1);

            Assert.IsFalse(duplicates.Any());
        }
    }
}
