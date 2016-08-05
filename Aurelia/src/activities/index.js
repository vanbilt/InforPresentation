import {HttpClient} from 'aurelia-http-client';

export class Activities{
	constructor(http) {
		this.heading = 'Activities';
		this.email = '';
		this.password = '';
		this.activities = [];
		this.error = null;
		this.selectOptions = [
			{ value: 'all', name: 'All'},
			{ value: '1', name: '1'},
			{ value: '2', name: '2'},
			{ value: '3', name: '3'},
			{ value: '4', name: '4'},
			{ value: '5', name: '5'},
			{ value: '6', name: '6'},
			{ value: '7', name: '7'},
			{ value: '8', name: '8'},
		];
		this.selectedVal = 'all';
		this.id = this.selectedVal;
	}
  
	getActivity (id) {
		var url = '/api/activity' 
		url += (id.toLocaleLowerCase() === 'all') ? '' : '/' + id;

		let client = new HttpClient()
			.configure(c => {
				c.withHeader('Authorization', 'Basic ' + 
					btoa(this.email + ':' + this.password))
			});

		// return the promise, success or error
		return client.get(url)
			.then(
				//success
				function (data) {
					return data;
				},
				//error
				function (e){
					// same as Promise.reject
					throw new Error(e.statusCode + ' ' + e.statusText);
				});
	}

	getActivities () {
		var self = this;
		// blank out activities array with each .get()
		this.activities = [];
		// blank out the error object with each .get()
		this.error = null;
		this.getActivity(this.selectedVal.value).then(
			function (result) {
				var activities = JSON.parse(result.response);
				if(isNaN(activities.length)) {
					self.activities.push(activities);
				} else {
					for(var i = 0; i < activities.length; i += 1) {
						self.activities.push(activities[i])
					};
				}
			},
			function (e) {
				self.error = e;
			}
		);
	}

	setCredentials () {
		this.email = 'interview@infor.com';
		this.password = 'interview';
	}
}