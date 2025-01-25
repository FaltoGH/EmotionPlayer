using System;
using System.Windows.Controls;

namespace EmotionPlayer.Tests
{
    [TestClass]
    public class Test1
    {
        [STATestMethod]
        public void RemoveSelectionTests()
        {
            var listBox = new ListBox();
            listBox.Items.Add(null);
            listBox.SelectedIndex = 0;
            Assert.AreEqual(0, listBox.SelectedIndex);
            listBox.RemoveSelection();
            Assert.AreEqual(-1, listBox.SelectedIndex);
        }
    }
}
