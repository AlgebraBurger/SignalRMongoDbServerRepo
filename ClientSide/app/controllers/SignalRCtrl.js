angular.module("app")    
    .constant("baseurl", "#")
    .controller("SignalRCtrl", ['$scope', '$http', '$rootScope','baseurl',
	function ($scope, $http, $rootScope,  baseurl) {
	
		var m = "";

		$.connection.hub.url = '//192.168.1.33:8089/signalr';
		//$.connection.hub.logging = true;					   
		connection = $.connection.customerHub;
		connection.client.receiveMessage = function (data) {	    				
           	 $rootScope.$apply(function () {       
           	 		console.log(data);
           	 		 m += data;
                     $scope.message = m;
                });           
		};
 		
		$.connection.hub.start().done(function () {		         
			//connection.server.hello();
		}).fail(function (failreason) {
			console.log(failreason);
		});

	}
]);

