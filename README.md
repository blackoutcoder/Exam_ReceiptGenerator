<|||||> Exam_ReceiptGenerator <|||||>
 ClassModels folder added <|||||>
 Item.cs added in ClassModels folder<|||||>
 Order.cs added in ClassModels folder<|||||>
 OrderItem.cs added in ClassModels folder<|||||>
 DataAccess folder added <|||||>
 ItemRepository.cs added in DataAccess folder<|||||>
 OrderRepository.cs added in DataAccess folder<|||||>
 Functions folder added <|||||> 
 he reason i'm not adding new project for Class objects and Repositories is a build failure CS0006. Can't fix it... <|||||>
 Comments added for Program.cs, OrderRepository.cs, Item.cs <|||||>
 Methods.cs added in Functions folder for putting methods there <|||||>
 DataPrint.cs data was moved to Methods.cs <|||||>
 DataPrint.cs was removed <|||||>
 Print() method added in Methods.cs(65, 5) <|||||>
 Some syntax errors fixed in methods.cs(33, 13), comments added in OrderItem.cs <|||||>
 Readme.txt view improvements for GitHub <|||||>
 Comments style fixed (now more comfortable to read comment and code) <|||||>
 PrintOrderData() method  modifyed in Methods.cs(59, 9), added posibility to view any generated order details by entering an Order number daclaired by Order Generator. Thinking about putting it all in a method.. <|||||>
 Check algorithm added to check an entered order number in PrintOrderData() method in Methods.cs(61, 9), checks if an entered number is not a string value and if an entered value is higher than 0 and lower than number of generated orders <|||||>
 Visual improvements added in Console view, now orderes listed in colours for more comfort <|||||>
 Generator() method added to ItemRepository.cs(35, 5), generates random list of items in order every time we generating a new order <|||||>
 CountItem() method added to Order.cs to count total number of items in all orders <|||||>
 'Total items sold:' calculation added to report details. <|||||>
 CountItemChosen(int index) method added to Order.cs to calculate the number of items in all orders by the chosen item index <|||||>
 Price visibility fixed in Console for orders, also added 'Total calculation' to calculate total summ in Euro payed for each Item in order <|||||> 
 Serializer.cs added to Function <|||||> 
 Serialize(List<Order> orders) method added whith takes a list of orders and writes it to a .txt and .json files in local directory <|||||> 
 *.cs files formatted <|||||> 