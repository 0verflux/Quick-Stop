# Quick-Stop
A Simple Hotel Booking System designed for users to find hotels in four locations provided with a filter, and allows viewing of Full Hotel Details on selecting in the list.
Once the user wants to book a room, the user is required to provide the guest count, and checks in/out. The user is also allowed to view the booking by enting the reference provided.

Dependencies:
- Unity Container
- .NET Framework 4.6.1

A solution is provided if a certain problem occurs:
1. `Couldn't process file ***.resx due to its being in the Internet or Restricted zone or having the mark of the web on the file.`
    - Open `Quick-Stop.Client > Forms` in the File Explorer
    - Right Click each `.resx` file and select Properties
    - Check the checkbox to unblock
2. `Unity` package is not loaded/found
    - Right click the solution in solution folder
    - Clean the solution
