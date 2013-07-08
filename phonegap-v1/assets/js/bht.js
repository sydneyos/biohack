(function(w){
	var d = w.document;
	var measuresModel;

	var $ = w.$ = function(id){
		return d.getElementById(id);
	};

	var bht = {
		currentView: null,
		hideAllViews: function(){
			var views = d.querySelectorAll('.view');
			for (var i=0, l=views.length; i<l; i++){
				views[i].classList.add('hidden');
			}
		},
		setTitle: function(str){
			var title = 'BioHack This!';
			if (str){
				str = str.replace(/^\s+|\s+$/g, ''); // trim
				if (str.toLowerCase() != title.toLowerCase()){
					title = str + ' – ' + title;
				}
			}
			document.title = title;
		}
	};

	// Log API failures/errors to GA
	if (typeof _gaq != 'undefined') bht.sub('logAPIError', function(type){
		_gaq.push(['_trackEvent', 'Errors', 'API', type]);
	});

	// Fix browsers freak out of amplify.store.sessionStorage not a function
	if (!amplify.store.sessionStorage || typeof amplify.store.sessionStorage != 'function'){
		amplify.store.sessionStorage = amplify.store.memory; // Fallback to in-memory storage
	}

	function SetupViewModel() {
	};

	function MeasuresViewModel() {
		var cacheName = 'measures-cache';
		var self = this;

		//properties

		self.Measures = ko.observableArray([]);
		self.Visible = ko.observable(false);

		//functions

		self.addMeasure = function (measure) {
			Measures.push(measure);
			amplify.store()
		};

		self.deleteMeasure = function(measure) {
			Measures.remove(measure);
		};

		self.loadMeasures = function () {
			var measures = amplify.store(cacheName);
			if (measures) {
				self.Measures(pushAll);
			};
		};

		self.render = function () {
			self.Visible(true);
		}

		self.loadMeasures();
	}

	bht.init = function(){
		measuresModel = new MeasuresViewModel();
		measuresModel.render();
		ruto.init();
	};

	w.bht = bht;

	ruto
		.config({
			before: function(path, name){
				bht.hideAllViews();
				var view = $('view-' + name);
				view.classList.remove('hidden');
				bht.currentView = name;
				bht.setTitle(view.querySelector('header h1').textContent);
			},
			notfound: function(){
				ruto.go('/');
			}
		})
		.add('/', 'home')
		.add('/about', 'about')
		.add(/^\/item\/(\d+)$/i, 'comments', function(path, id){
			bht.comments.render(id);
		});


	// Adjust min-height on the views based on the viewport
	// While waiting for viewport units to be more widely supported by modern browsers
	var head = d.head || d.getElementsByTagName('head')[0];
	var adjustViewsHeight = function(){
		var vh = window.innerHeight;
		var style = $('view-height');
		if (!style){
			style = d.createElement('style');
			style.id = 'view-height';
			head.appendChild(style);
		}
		style.textContent = '.view>.scroll{min-height: ' + (vh*.85) + 'px}';
	};
	w.addEventListener('resize', adjustViewsHeight, false);
	w.addEventListener('orientationchange', adjustViewsHeight, false);
	adjustViewsHeight();

	bht.init();
})(window);