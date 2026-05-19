# Solution
See below for the problem specification.

## Summary

This solution is a basic checkout system to calculate the total price of scanned items. 

It supports the following:
* Scan items into a basket
* Individual unit pricing per SKU
* Special offers for purchasing multiple SKUs
* Exception handling for incorrect or missing SKU identifiers
* Dependency injection for special offers when constructing the Checkout

## Approach

Test driven development was what I intended to showcase with this solution. 

Beyond initial set up of the basic library components to act as a framework for the project, unit tests were created before continuing with creating the scanning and pricing logic. Unit test defined the requirements for each method, and once working were then refactored. 

## Design Considerations

### KISS 

The aim was to keep this project as simple as possible whilst following the instructions outlined below. 

* Two projects are contained within one solution to handle Unit Tests and library components
* Constants used by the unit tests are kept separate from the main library
* Folders and namespaces are used as appropriate to keep the entire solution organised and easy to navigate
* ItemPrice.cs holds the SKU, UnitPrice, SpecialPrice
* Total price per SKU type is handled with ItemPrice.cs and later summed in Checkout.cs to simplify keep GetTotalPrice() more readable 
* SpecialPrice.cs is nullable and used as a variable within ItemPrice.cs to handle SKUs with or without special offers

### Exception Handling 

* Specific exceptions created as appropriate for different points of failure within Checkout.cs
* Unit Tests created to ensure these exceptions are thrown when necessary

============================================================================================
# Checkout-Kata Specification

In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our shop, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually. In addition, some items are multipriced: buy n of them, and they’ll cost you y pounds. For example, item ‘A’ might cost 50 pounds individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130. The current pricing and offers are as follows:

| SKU | Unit Price | Special Price |
| --- | ---------- | ------------- |
| A   | 50         | 3 for 130     |
| B   | 30         | 2 for 45      |
| C   | 20         |               |
| D   | 15         |               |

Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95). Because the pricing changes frequently, we need to be able to pass in a set of pricing rules each time we start handling a checkout transaction.

## Suggested Interface

```csharp
interface ICheckout
{
    void Scan(string item);
    int GetTotalPrice();
}
```

## Instructions

Implement a class library that satisfies the problem described above. The solution should be test driven.

We're as interested in the process that you go through to develop the code as the end result, so commit early and often so we can see the steps that you go through to arrive at your solution. We want to see a git repository containing your solution, ideally uploaded to your own github account.

If you've not done a kata before, there are some great reources on the web describing the process.
