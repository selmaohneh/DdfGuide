using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DdfGuide.Tests
{
    [TestClass]
    public class DtoFileTests
    {
        private IEnumerable<AudioDramaDto> _dtos;

        [TestInitialize]
        public void Init()
        {
            var json = File.ReadAllText("../../../../dtos.json");
            _dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);
        }

        [TestMethod]
        public void DtoFileContainsNoDuplicateIds()
        {
            var duplicates = _dtos.GroupBy(x => x.Id).Where(x => x.Count() > 1);

            Assert.IsFalse(duplicates.Any());
        }

        [TestMethod]
        public void DtoFileContainsAtLeast300Episodes()
        {
            var enoughEpisodesExist = _dtos.ToList().Count > 300;

            Assert.IsTrue(enoughEpisodesExist);
        }

        [TestMethod]
        public void DtoFileContainsTitlesWithSpecialCharacters()
        {
            var episode229 = _dtos.Single(x => x.NumberEuropa == 229 && x.Interpreter == "Die drei ???");
            Assert.AreEqual("Drehbuch der Täuschung", episode229.Title);

            var episode205 = _dtos.Single(x => x.NumberEuropa == 205 && x.Interpreter == "Die drei ???");
            Assert.AreEqual("Das rätselhafte Erbe", episode205.Title);
        }

        [TestMethod]
        public void DtoFileContainsNoEmptyRoles()
        {
            var containsEmptyRoles = _dtos.Any(x => x.Roles.Any(y => string.IsNullOrWhiteSpace(y.Speaker) || string.IsNullOrWhiteSpace(y.Character)));
            Assert.IsFalse(containsEmptyRoles);
        }
    }
}
