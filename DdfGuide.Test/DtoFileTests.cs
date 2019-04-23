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
        private IEnumerable<AudioDramaDto> _dtos;

        [TestInitialize]
        public void Init()
        {
            var json = File.ReadAllText("../../../dtos.json");
            _dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);
        }

        [TestMethod]
        public void DtoFileContainsNoDuplicateIds()
        {
            var duplicates = _dtos.GroupBy(x => x.Id).Where(x => x.Count() > 1);

            Assert.IsFalse(duplicates.Any());
        }
    }
}
