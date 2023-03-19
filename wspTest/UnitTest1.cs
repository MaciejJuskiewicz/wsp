using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace wsp.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestButtonClick()
        {
            // Arrange
            Form1 form = new Form1();
            Button button = form.Controls["button1"] as Button;
            RichTextBox richTextBox = form.Controls["richTextBox1"] as RichTextBox;

            // Act
            

            // Assert
            Assert.AreEqual("", richTextBox.Text);

        }
    }
}
