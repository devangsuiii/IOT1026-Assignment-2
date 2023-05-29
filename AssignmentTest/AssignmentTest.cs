using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        /// <summary>
        /// Tests the Unlock method of the TreasureChest class.
        /// </summary>
        [TestMethod]
        public void UnlockTest()
        {
            // Create a new chest that is initially locked
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);

            // Unlock the chest
            chest.Unlock();

            // Verify that the chest is now in the closed state
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        /// <summary>
        /// Tests the Lock method of the TreasureChest class.
        /// </summary>
        [TestMethod]
        public void LockTest()
        {
            // Create a new chest that is initially closed
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);

            // Lock the chest
            chest.Lock();

            // Verify that the chest is now in the locked state
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        /// <summary>
        /// Tests the Open method of the TreasureChest class.
        /// </summary>
        [TestMethod]
        public void OpenTest()
        {
            // Create a new chest that is initially closed
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);

            // Open the chest
            chest.Open();

            // Verify that the chest is now in the open state
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }

        /// <summary>
        /// Tests the Close method of the TreasureChest class.
        /// </summary>
        [TestMethod]
        public void CloseTest()
        {
// Create a new chest that is initially open
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);

            // Close the chest
            chest.Close();

            // Verify that the chest is now in the closed state
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }
    }
}