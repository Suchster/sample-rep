// This js file can referenced in html with <script src="lesson1.js"></script>
// Before ES6 the variables were declared var but this had issues now let is used
let name;
console.log(name); // This will show name is undefined
name = 'Luis'
console.log(name); // This will show Luis
// Naming rules for variables:
// 1.They cannot be a reserved keyword
// 2.Must be meaningful and descriptive
// 3.Cannot satrt with a number
// 4.Cannot contain a space or hyphen (-)
// Variables are case sensitive
// Example of good use: let firstName;

// Usage with constants

const interestRate = 0.3;
// if we try to reasign a const we will have an error say interestRate = 0; will throw an error
// Primitive Value types, symbol shown later
let firstName = 'Luis'; // String literal
let lastName = null; // Just null, used more the undefined and is an object type
let age = 25; // Number Literal
let isApproved = true; // Boolean literal
let favColor = undefined; // Undefined variable type

// This makes javascrip a Dynamic language instead of Static, which means variable types can be changed at any moment
typeof firstName; // Will throw String
firstName = 1; // We set the variable to integer
typeof firstName; // will throw Number (Floats are also considered Number type)

// Reference types (Objects, Arrays and Functions)

// Objects
// Declaration:
let person =  {
    name: 'Angel',
    age: 24
};

console.log(person); // Will show us the properties

// Make changes using Dot notation:
person.name = 'Luis';
console.log(person.name);
// Bracket notation:
person['name'] = 'Mary'
// Notes on Bracket notation can be used when the type is not known and name can be set on a variable ex.
let selection = 'name';
person[selection] = 'John'; 

// Arrays
// Declaration:
let selectedColors = ['red', 'green']; // reminder js is dynamic and this also applies to arrays, the length can be changed and can store different types
console.log(selectedColors);
selectedColors[2] = 'blue';
selectedColors[3] = 1;
// Result: red, green, blue, 1
typeof selectedColors; // An array is an object in js

// Functions 
// Declaration:
function greet(){
    console.log("Hello World!");
}

// Calling
greet();

//Inputs in functions
function greetName(name, lastName){
    console.log('Hello ' + name);
}
firstName = 'Luis';
lastName = 'Angel'
greetName(firstName, lastName); // We send these arguments to be used on the functions parameters

// function used for calculating and returning an answer
function square(number){
    return number*number;
}

console.log(square(2));

// This has been the end of this lesson.