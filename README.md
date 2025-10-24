# Development/Migrations description for Student Management  
## Incremental vs State-based  

Before I descrip the different migration I firste want to descip my definition og the different types of migration.  
Incremental:  
Incremental migrations apply versioned schema changes step by step, safely evolving the database over time and minimizing data risks.  
  
State-based:  
Definition state-based migrations rebuild the schema to match the current model quickly but can be risky, as they may overwrite or drop existing data.  
  
## Branch 1 Create initial db structure  Create-model-migration
Branch Link: https://github.com/dansmi01/DFD_Compulsory_Take2/tree/Creat-model-migration 

This is the first branch for setting up the initial files and models for the student management system, including the context for the database connection.
There are no deliberate migrations at work here since it serves as the foundation for future migrations.
Database schema before the first EF migration    
<img width="1251" height="949" alt="image" src="https://github.com/user-attachments/assets/d045a9a8-dc3b-4fca-834d-62c975a254e5" />    
  
## Branch 2 feature/student-course-enrollment-tables) 
Branch Links: https://github.com/dansmi01/DFD_Compulsory_Take2/tree/feature/student-course-enrollment-tables  
In this branch the goal is to use the created db model and initiate the different models into tables in the database using EF(EntityFrameWork) 
The proces done incremental because the schema first was made and the it the blueprint for the table relations.  
  
Afterward the data was inserted into the different tables. 

## Branch 3 alter schema and add professors and departments with foreign keys.  
Branch link: https://github.com/dansmi01/DFD_Compulsory_Take2/tree/feature/professor-department-migrations   
This sranch is made to work with first Incremental migration by adding departments and professors  

First I create the new models Professors and Department to follow the newly drawn DB schema. Incemental migration 

<img width="1264" height="1671" alt="image" src="https://github.com/user-attachments/assets/7a5a2c46-4c31-4604-a9c7-809d37a046cc" />

After the the models is created I  initiate them for migration into the database.  

## Branch 4 Add automatic date for course start state-based migration 
Branch Link: https://github.com/dansmi01/DFD_Compulsory_Take2/tree/StartDate-Migration
This last migration where a more traditoinal stastebased migration where i add the start date for the different course.  
These are set ate the first monday of september. this was done by making firs an empty migration and the adding the specific changes to the teable row which where null. 
After the migration the following where displayed in the database.

<img width="481" height="597" alt="image" src="https://github.com/user-attachments/assets/20c8142e-5bf6-4f10-b0d3-64fa4ad430da" />

Since the focus of the assignemn where to display migratioin i didnt focus on the date format, also the reason the grade is null is because the isea is it dist is when a student is done with the course the should be added a grade. 





  
  



