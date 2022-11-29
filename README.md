# vending-machine-oxford-economics
Sample code written by Marlon Dedakis - 29/11/2022

## Notes

- A service called IProductsDomain is initialized in Program.cs (line 8)
- The Home Controller injects the IProductsDomain and uses this domain to get all products
- Models > ProductViewModel contains the Name and Price of each product, since this is a demo project, the ID is generated dynamically upon retrieving the ProductId (as a GUID)
- The list of Products is then passed as a ViewModel to the Razor view so that it can be strongly typed within the view
- Please note accessibility has not been implemented, i.e. tabbing skips the 'Insert coin' element