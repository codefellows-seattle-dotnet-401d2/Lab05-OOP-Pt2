# Codefellows Schoolbuilder
## About
This is a proof-of-concept software designed by Dustin Mundy.
## Contains
### Classes
#### Codefellows
This is the root class for the entire data structure. An instance of this class will include empty lists for Staff (StaffMember) Students (Student) and Classes (Cohort). First instantiate this instance with ```CodeFellows codefellows = new CodeFellows();```

Once that is done, you can use methods OpenClass, NewInstructor and NewStudent to add new data to your instance.

#### Cohort
This is a "Class" within the school Codefellows. In order to ensure that each class gets added properly to a schools class list, use ```codefellows.OpenClass(<subject>,<level>,<instructor full name>);```. As a valid instructors name must match one in the CodeFellows Instructor list, add an instructor before instantiating this class.

#### Person (Abstract)
No need to worry about this one, it only exists to define the common traits between Students and StaffMembers.

#### Student
A student is a person with a FirstName, LastName, Email and PhoneNumber. They can be created using ```codefellows.NewStudent(<firstname>,<lastname>,<email>,<phonenumber>)``` and added into a Cohort by calling the method ```codefellows.Classes[<cohort index>].NewStudent(<student Object>)```

#### StaffMember
A staffmember is a person with a FirstName, LastName, Email, PhoneNumber and JobTitle. They can be created using ```codefellows.NewInstructor(<firstname>,<lastname>,<email>,<phonenumber>,<jobtitle>)``` and added into a Cohort by calling the method ```codefellows.Classes[<cohort index>].NewInstructor(<instructor Object>)```

### Methods
#### DisplayCohort
Writes info on a cohort to console.
Usage: ```codefellows.DisplayCohort(<index of cohort>)```