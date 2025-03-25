using Lab1_2;

namespace Lab1_2_Testy
{
    [TestClass]
    public sealed class KnapsackProblemTest
    {
        [TestMethod]
        public void Solve_MinOneElementWithinBoundaries_ReturnsMinOneElement()
        {
            // Arrange
            var problem = new Problem(10, 1);
            int capacity = 1;

            // Act
            var result = problem.Solve(capacity);

            // Assert
            Assert.IsTrue(result.SelectedItems.Count >= 1);
        }

        [TestMethod]
        public void Solve_NoElementWithinBoundaries_ReturnsEmptyList()
        {
            // Arrange
            var problem = new Problem(10, 1);
            int capacity = 0;

            // Act
            var result = problem.Solve(capacity);

            //Assert
            Assert.AreEqual(result.SelectedItems.Count, 0);
        }

        [TestMethod]
        public void Solve_ProblemInstance_IsCorrect()
        {
            // Arrange
            List<int> selectedItems = new List<int> {5, 4, 3, 6, 8, 1, 7};
            int totalWeight = 49;
            int totalValue = 100;
            int capacity = 50;
            var problem = new Problem(10, 1);

            // Act
            var result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(result.TotalValue, totalValue);
            Assert.AreEqual(result.TotalWeight, totalWeight);
            CollectionAssert.AreEqual(result.SelectedItems, selectedItems);
        }

        [TestMethod]
        public void Solve_ProblemInstance_TotalWeightLessThanCapacity()
        {
            // Arrange
            int capacity = 30;
            var problem = new Problem(10, 1);

            // Act
            var result = problem.Solve(capacity);

            // Assert
            Assert.IsTrue(result.TotalWeight <= capacity);
        }

        [TestMethod]
        public void Solve_AllElementsWithinBoundaries_ReturnsAllItems()
        {
            // Arrange
            int numberOfItems = 10;
            var capacity = 200;
            var problem = new Problem(numberOfItems, 1);

            // Act
            var result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(numberOfItems, result.SelectedItems.Count());
        }
    }
}
