# Inventory System
A small project written in C# 4.7.2 that allows for managing parts and products using forms.

The requirements for this application are as follows:

---
For this assessment, you will create a C# application using the solution statements provided in the requirements section. Your submission should include a zip file with all the necessary code files to compile, support, and run your application.

I. User Interface

Create a C# application with a graphical user interface (GUI) based on the attached “GUI Mock-Up.” Write code to display each of the following forms in the GUI:

1. A main form, showing the following controls: • buttons for “Add,” “Modify,” “Delete,” “Search” for parts and products, and “Exit” • lists for parts and products • text boxes for searching for parts and products • title labels for parts, products, and the application title

2. An add part form, showing the following controls: • radio buttons for “In-House” and “Outsourced” parts • buttons for “Save” and “Cancel” • text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID • labels for ID, name, inventory level, price/cost, max and min values, the application title, and company name or machine ID

3. A modify part form, with fields that populate with data from an existing Part, showing the following controls: • radio buttons for “In-House” and “Outsourced” parts • buttons for “Save” and “Cancel” • text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID • labels for ID, name, inventory level, price, max and min values, the application title, and company name or machine ID

4. An add product form, showing the following controls: • buttons for “Save,” “Cancel,” “Add” part, and “Delete” part • text boxes for ID, name, inventory level, price, and max and min values • labels for ID, name, inventory level, price, max and min values, and the application • a grid view for all parts • a grid view for parts associated with the product • a “Search” button and a text field with an associated list for displaying the results of the search

5. A modify product form, with fields that populate with data from an existing product, showing the following controls: • buttons for “Save,” “Cancel,” “Add” part, and “Delete” part • text boxes for ID, name, inventory level, price, and max and min values • labels for ID, name, inventory level, price, max and min values, and the application “all candidate parts” • a grid view for parts associated with the product • a “Search” button and a text box with associated list for displaying the results of the search

II. Application

Now that you’ve created the GUI, write code to create the class structure provided in the attached “UML (unified modeling language) Class Diagram.” Enable each of the following capabilities in the application:

6. Using the attached “UML Class Diagram,” create appropriate classes and instance variables with the following criteria: • five classes with the all associated properties • variables are accessible/modifiable through properties

7. Add the following functionalities to the main form, using the methods provided in the attached “UML Class Diagram”: • redirect the user to the “Add Part,” “Modify Part,” “Add Product,” or “Modify Product” forms • delete a selected part or product from the grid view • search for a part or product and display matching results • exit the main form

8. Add the following functionalities to the part forms, using the methods provided in the attached “UML Class Diagram”:
    - “Add Part” form • select “In-House” or “Outsourced” • enter name, inventory level
    - price
    - max and min values
    - company name or machine ID • save the data and then redirect to the main form • cancel or exit out of this form and go back to the main form
    - “Modify Part” form • select “In-House” or “Outsourced” • modify or change data values • save modifications to the data and then redirect to the main form • cancel or exit out of this form and go back to the main form

9. Add the following functionalities to the product forms, using the methods provided in the attached “UML Class Diagram”:
    - “Add Product” form • enter name, inventory level
    - price
    - max and min values • save the data and then redirect to the main form • associate one or more parts with a product • remove or disassociate a part from a product • cancel or exit out of this form and go back to the main form
    “Modify Product” form • modify or change data values • save modifications to the data and then redirect to the main form • associate one or more parts with a product • remove or disassociate a part from a product • cancel or exit out of this form and go back to the main form

10. Write code to address the following conditions with exception handling code: • Detect non-numeric values in textboxes that expect numeric values • Min should be less than Max; and Inv should be between those two values • Prevent the user from deleting a product that has a Part associated with it • Confirm “Delete” actions
