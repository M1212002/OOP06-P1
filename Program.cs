#region Q1
// abstraction means showing only the important features of an object and hiding the complex implementation details.
// So, the user knows what the object does, but not how it does it.
// encapsulation means bundling data and the methods that operate on that data into one unit (class) and restricting direct access to the data.
// So, abstraction hides implementation details , while encapsulation hides data. Also, abstraction focuses on what the object does , while 
// encapsulation focuses on protecting data.

// Example : coffee machine 
// when you use a coffee machine, you usually press a button like espresso , latte , cappuccino , you don't see or deal with the internal
// process such as heating the water , grinding the coffee beans , mixing milk and coffee , you just press a button and get the drink. So ,
// this is abstraction , the machine shows only the simple interface (buttons) and hides the complex internal process.
// inside the coffee machine there are internal data and operations such as water temperature , coffee amount milk quantity. These values cannot
// be changed directly by the user , they are controlled by the machine's internal system. So , this is encapsulation , the internal data
// is protected and accessed only through controlled methods.
#endregion

#region Q2
// abstract class : 
// 1. used to share common base functionality
// 2. can have methods with implementation
// 3. can have constructors
// 4. a class can inherit only one abstract class

// interface : 
// 1. used to define a contract
// 2. usually only method declarations
// 3. can't have constructors
// 4. a class can implement multiple interfaces

// use abstract class when : classes are closely related , you want to share common code , you need fields, constructors, or default methods.
// use interface when : you want to define a capability or behavior , classes may be unrelated , you need multiple inheritance of behavior.
#endregion

#region Q3
// a. No , I can't , because Appliance is an abstract class and abstract classes can't be instantiated directly , they are meant to be base classes
// that other classes inherit from.

// b. PowerConsumption() - abstract method : no implementation in the base class and every derived class must override it. The designer made it abstract
// because different appliances consume different amounts of power, so the base class cannot define a default value.
// Status() - virtual method : has a default implementation and child classes may override it but are not required. The designer made it virtual because
// most appliances may be in standby, but some appliances may have their own status.
// Label() - concrete method : fully implemented and not intended to be overridden. The designer made it concrete because the logic for creating the
// label is the same for all appliances , showing the brand and the power consumption. So , there is no need for child classes to change this behavior.

// c. it will return Standby , because Toaster does not override the Status() method , so it uses the default implementation from the base class Appliance.
#endregion

#region Q4
// a. a partial class allows a class definition to be split across multiple files, but at compile time the compiler combines them into a single class.
// developers use partial classes for better organization of large classes , separating different responsibilities and generated code vs manual code. In , this
// example , Calculator.cs has the main calculator logicx and Calculator.Logging.cs has the logging functionality and this keeps the main logic clean and easier to maintain.

// b. a partial method is a method that is declared in one part of a partial class and optionally implemented in another part. 
// Yes , the code will still compile because if a partial method has no implementation, the compiler removes both ( the method declaration , the method call).

// c. an extension method allows you to add new methods to an existing type without modifying the original class.
// Rules : 
// 1. the method must be inside a static class
// 2. the method itself must be static
// 3. the first parameter must use the this keyword to specify the type being extended

// d. it will print :
// Log: result = 20
// $20.00
#endregion