using EvaluationSampleCode;

namespace EvaluationSampleCodeTest
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper? _htmlFormatHelper;

        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        [TestMethod]
        [DataRow("test", "<b>test</b>")]
        [DataRow("Hello World", "<b>Hello World</b>")]
        [DataRow("", "<b></b>")]
        public void GetBoldFormat_WithValidInput_ReturnsBoldHtmlString(string input, string expected)
        {
            // Act
            string result = _htmlFormatHelper!.GetBoldFormat(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("test", "<i>test</i>")]
        [DataRow("Hello World", "<i>Hello World</i>")]
        [DataRow("", "<i></i>")]
        public void GetItalicFormat_WithValidInput_ReturnsItalicHtmlString(string input, string expected)
        {
            // Act
            string result = _htmlFormatHelper!.GetItalicFormat(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFormattedListElements_WithValidList_ReturnsFormattedHtmlList()
        {
            // Arrange
            var inputList = new List<string> { "Item 1", "Item 2", "Item 3" };
            var expected = "<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>";

            // Act
            string result = _htmlFormatHelper!.GetFormattedListElements(inputList);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFormattedListElements_WithEmptyList_ReturnsEmptyHtmlList()
        {
            // Arrange
            var inputList = new List<string>();
            var expected = "<ul></ul>";

            // Act
            string result = _htmlFormatHelper!.GetFormattedListElements(inputList);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetBoldFormat_WithNullInput_ThrowsArgumentNullException()
        {
            _htmlFormatHelper!.GetBoldFormat(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetItalicFormat_WithNullInput_ThrowsArgumentNullException()
        {
            _htmlFormatHelper!.GetItalicFormat(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFormattedListElements_WithNullList_ThrowsArgumentNullException()
        {
            _htmlFormatHelper!.GetFormattedListElements(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFormattedListElements_WithNullItem_ThrowsArgumentNullException()
        {
            var list = new List<string> { "Item 1", null, "Item 3" };
            _htmlFormatHelper!.GetFormattedListElements(list);
        }
    }
}