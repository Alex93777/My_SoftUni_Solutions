using NUnit.Framework;
using System;
using System.Text;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string productName = "apple";
        double productPrice = 1.99;
        int productQuantity = 2;

        string expected = $"Product Inventory:{Environment.NewLine}apple - Price: $1.99 - Quantity: 2";

        // Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);
        string output = _inventory.DisplayInventory();

        // Assert

        Assert.That(output, Is.EqualTo(expected));


    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = $"Product Inventory:";

        // Act       
        string output = _inventory.DisplayInventory();

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string productName = "apple";
        double productPrice = 1.99;
        int productQuantity = 2;

        string productName2 = "banana";
        double productPrice2 = 1.50;
        int productQuantity2 = 2;

        string productName3 = "cherry";
        double productPrice3 = 2.50;
        int productQuantity3 = 2;

        string expected = $"Product Inventory:{Environment.NewLine}apple - Price: $1.99 - Quantity: 2" +
                            $"{Environment.NewLine}banana - Price: $1.50 - Quantity: 2" +
                            $"{Environment.NewLine}cherry - Price: $2.50 - Quantity: 2";

        // Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);
        this._inventory.AddProduct(productName2, productPrice2, productQuantity2);
        this._inventory.AddProduct(productName3, productPrice3, productQuantity3);
        string output = _inventory.DisplayInventory();

        // Assert

        Assert.That(output, Is.EqualTo(expected));

    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0;

        // Act       
        double output = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string productName = "apple";
        double productPrice = 1.99;
        int productQuantity = 2;

        string productName2 = "banana";
        double productPrice2 = 1.50;
        int productQuantity2 = 2;

        string productName3 = "cherry";
        double productPrice3 = 2.50;
        int productQuantity3 = 2;

        double expected = 11.98;

        // Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);
        this._inventory.AddProduct(productName2, productPrice2, productQuantity2);
        this._inventory.AddProduct(productName3, productPrice3, productQuantity3);
        double output = _inventory.CalculateTotalValue();

        // Assert

        Assert.That(output, Is.EqualTo(expected));
    }
}
