import {HttpClient} from 'aurelia-http-client';

export class App {
	configureRouter(config, router) {
		this.router = router;
		config.title = 'Infor Presentation :: Aurelia';
		config.map([
			{ 
				route: ['', 'todos'],
				name: 'todos',
				moduleId: 'todos/index',
				title: 'Todos',
				nav: true 
			},
			{ 
				route: ['activities'],
				name: 'activities',
				moduleId: 'activities/index',
				title: 'Activities',
				nav: true 
			},
			{
				route: ['404'],
				name: '404',
				moduleId: '404/index',
				title: '404',
				nav: true 
			}
		]);

		config.mapUnknownRoutes('404/index');
	}

	// for testing purposes...
	constructor() {
		this.message = 'Hello World!';
	}
}
