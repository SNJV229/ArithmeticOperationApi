# ArithmeticOperationApi
Implement controller that exposes Math class over web api. The functions name of the controller shouldnt be same as the webapi endpoint.Enable Swagger

actually we have 3 options Transient, scoped and singleton... As here i have created created a single instance and re-using 
the same object in the all call so i have to use singleton but it have chances of memory leaks so for light weight services 
we can use Transient and is is always better to use scoped when we want to maintain state within a request.

![image](https://user-images.githubusercontent.com/38901682/191743569-0cb5af86-b337-421c-b2c2-938c2a1b56f4.png)

