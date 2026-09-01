using StockValueCalculator;

namespace StockValueCalculatorTests
{
    public class InventoryTests
    {
        [Fact]
        public void TestTotalStockValue()
        {
            //Arrange
            decimal expectedTotalStockValue = 113.16m;

            //Act
            Inventory inventory = new Inventory();
            inventory.AddBook("Hard Ground", "Tom Waits" , 184, 8.99m);
            inventory.AddCD("Blood Money", "Tom Waits", 13, 9.99m);
            inventory.AddBook("The World's Greatest Books", "John Bramwell", 1254, 84.99m);
            inventory.AddCD("Sky at Night", "I am Kloot", 12, 5.99m);

            //Assert
            Assert.Equal(expectedTotalStockValue, inventory.TotalStockValue);



        }
    }
}