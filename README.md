<|||||> Exam_ReceiptGenerator <|||||>
 ClassModels folder added <|||||>
 Item.cs added <|||||>
 Order.cs added <|||||>
 OrderItem.cs added <|||||>
 DataAccess folder added <|||||>
 ItemRepository.cs added <|||||>
 OrderRepository.cs added <|||||>
 Functions folder added <|||||> 
 he reason i'm not adding new project for Class objects and Repositories is a build failure CS0006. Can't fix it... <|||||>
 Comments added for Program.cs, OrderRepository.cs, Item.cs <|||||>
 Methods.cs added for putting methods there <|||||>
 DataPrint.cs data was moved to Methods.cs <|||||>
 DataPrint.cs was removed <|||||>
 Print() method added in Methods.cs(65, 5) <|||||>
 Some syntax errors fixed in methods.cs(33, 13), comments added in OrderItem.cs <|||||>
 Readme.txt view improvements for GitHub <|||||>
 Comments style fixed (now more comfortable to read comment and code) <|||||>
 PrintOrderData() method  modifyed in Methods.cs(59, 9), added posibility to view any generated order details by entering an Order number daclaired by Order Generator. Thinking about putting it all in a method.. <|||||>
 Check algorithm added to check an entered order number in PrintOrderData() method in Methods.cs(61, 9), checks if an entered number is not a string value and if an entered value is higher than 0 and lower than number of generated orders <|||||>
 Visual improvements added in Console view, now orderes listed in colours for more comfort <|||||>