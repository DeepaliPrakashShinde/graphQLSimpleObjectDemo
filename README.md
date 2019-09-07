# graphQL SimpleObject Demo
This will give the knowledge about how to fetch the data from simple json array.

Example:

``` "employees": [
      {
        "id": 1,
        "name": "John",
        "age": 23,
        "gender": "Male",
        "email": "john@emp.com"
      },
      {
        "id": 2,
        "name": "Anne",
        "age": 22,
        "gender": "Female",
        "email": "anne@emp.com"
      },
      {
        "id": 3,
        "name": "Jennifer",
        "age": 25,
        "gender": "Female",
        "email": "jennifer@emp.com"
      },
      {
        "id": 4,
        "name": "Benjamin",
        "age": 25,
        "gender": "Male",
        "email": "benjamin@emp.com"
      }
    ] ```


    In the above simple json example if you want to get the specific data like name,age for all the employee you need to use following graphQL query.```
	```
	Input:
    {
  		employees
  		{
    		name
    		age
		}
	}
	```

	
	```
	Output:
	{
	  "data": {
	    "employees": [
	      {
	        "name": "John",
	        "age": 23
	      },
	      {
	        "name": "Anne",
	        "age": 22
	      },
	      {
	        "name": "Jennifer",
	        "age": 25
	      },
	      {
	        "name": "Benjamin",
	        "age": 25
	      }
	    ]
	  }
	}
	```
