
/*
string[] fraudulentOrderIDs = new string[3]; REMEMBER USING NEW!!!!!

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000"; //System.IndexOutOfRangeException: Index was outside the bounds of the array. 
*/

/* string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); */

/* int[] inventory = { 200, 450, 700, 175, 250 };
int inventoryStock = 0;
int state= 0;
foreach (int element in inventory) {
    inventoryStock+=element;
    state++;
    Console.WriteLine($"The actual amout of items counted is {state}, and the current total stock is: {inventoryStock}");
    if (element==inventory[(inventory.Length-1)]) {
        Console.WriteLine($"The total amount of stock is {inventoryStock}"); 
        //this was awesome! im so impressed that it worked at the first time!
    }
} */

string[] fraudulentId= {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach (string id in fraudulentId) {
    if (id.StartsWith("B")){
        Console.WriteLine(id);
    }
}
