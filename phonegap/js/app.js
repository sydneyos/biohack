"use strict";

// Creating the application namespace
// Creating the application namespace
var MeasureTypes = Object.freeze({
    INPUT: { value: 1, name: 'Cause', pluralName: 'Causes' },
    OUTPUT: { value: 2, name: 'Effect', pluralName: 'Effects' },
    get: function(val) {
        if (val == 1) {
            return MeasureTypes.INPUT;
        }
        if (val == 2) {
            return MeasureTypes.OUTPUT;
        }
    }
});

var DataTypes = Object.freeze(
{ 
    BOOL:  { value: 1, name: 'Boolean', description: 'Present/Absent' },
    INTEGER: { value: 2, name: 'Integer', description: 'Count' },
    DECIMAL: { value: 4, name: 'Decimal', description: 'Decimal' },
    ORDINAL: { value: 3, name: 'Ordinal', description: 'Ordinal' },
    DISCRETE: { value: 5, name: 'Discrete', description: 'Discrete/Coded' }
});

var directory = {
    models: {},
    views: {},
    utils: {}
};

// -------------------------------------------------- Utilities ---------------------------------------------------- //

// The Template Loader. Used to asynchronously load templates located in separate .html files
directory.utils.templateLoader = {

    templates: {},

    load: function(names, callback) {

        var deferreds = [],
            self = this;

        $.each(names, function(index, name) {
            deferreds.push($.get('tpl/' + name + '.html', function(data) {
                self.templates[name] = data;
            }));
        });

        $.when.apply(null, deferreds).done(callback);
    },

    // Get template by name from hash of preloaded templates
    get: function(name) {
        return this.templates[name];
    }

};

// The in-memory Store. Encapsulates logic to access measure data.
directory.utils.store = {
    measures: {},

    populate: function() {
        window.localStorage.clear();
        var storedMeasures = localStorage.getItem("measures");
        if (storedMeasures) {            
            this.measures = JSON.parse(storedMeasures);
        } else {
            this.measures[1] = {id: 1, measureType: MeasureTypes.INPUT, dataType: DataTypes.ORDINAL, measureName: 'Chocolate', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[2] = {id: 2, measureType: MeasureTypes.INPUT, dataType: DataTypes.ORDINAL, measureName: 'Citrus', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[3] = {id: 3, measureType: MeasureTypes.INPUT, dataType: DataTypes.DECIMAL, measureName: 'Calories', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[4] = {id: 4, measureType: MeasureTypes.INPUT, dataType: DataTypes.INTEGER, measureName: 'Cups of Coffee', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[5] = {id: 5, measureType: MeasureTypes.INPUT, dataType: DataTypes.DECIMAL, measureName: 'Hours of Sleep', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[6] = {id: 6, measureType: MeasureTypes.INPUT, dataType: DataTypes.INTEGER, measureName: 'Carb grams', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[7] = {id: 7, measureType: MeasureTypes.OUTPUT, dataType: DataTypes.ORDINAL, measureName: 'Headache', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[8] = {id: 8, measureType: MeasureTypes.OUTPUT, dataType: DataTypes.DECIMAL, measureName: 'Weight', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
            this.measures[9] = {id: 9, measureType: MeasureTypes.OUTPUT, dataType: DataTypes.ORDINAL, measureName: 'Fatigue', createdAt: new Date(5,1,2013, 10, 0, 15, 0)};
        }
    },

    findById: function(id) {
        var measure = this.measures[id];
        return measure;
    },

    findAll: function() {
        return this.measures;
    },

    findByName: function(key) {
        var results = [];
        for (var id in this.measures) {
            if ( (this.measures[id].measureName).toLowerCase().indexOf(key.toLowerCase()) >= 0) {
                results.push(this.measures[id]);
            }
        }
        return results;
    },

    findByType: function(measureType) {
        var results = [];
        for (var id in this.measures) {
            if (this.measures[id].measureType.value == measureType) {
                results.push(this.measures[id]);
            }
        }
        return results;
    },

    saveMeasures: function() {
        window.localStorage.setItem("measures", JSON.stringify(this.measures));
    }
};

// Overriding Backbone's sync method. Replace the default RESTful services-based implementation
// with a simple local database approach.
Backbone.sync = function(method, model, options) {

    var store = directory.utils.store;

    if (method === "read") {
        if (model.id) {
            // Request to read a single item identified by its id.
            options.success(store.findById(model.id));
        } else if (model.measureType) {
            // Request to read a collection of measures identified by the manager they work for.
            options.success(store.findByType(model.measureType));
        } else {
            // Request to read a collection of all measures.
            options.success(store.findAll());
        }
    }

};

// -------------------------------------------------- The Models ---------------------------------------------------- //

// The measure Model
directory.models.measure = Backbone.Model.extend({
    defaults: {
        measureType: MeasureTypes.INPUT, 
        dataType: DataTypes.BOOL,
        measureName: 'Enter a name', 
        createdAt: new Date()
    },
    initialize: function() {
        var codes = new directory.models.codeCollection(this.get('codes'));
        codes.parentId = this.id;
        this.set('codes', codes);
        var ordinals = new directory.models.ordinalCollection(this.get('ordinals'));
        ordinals.parentId = this.id;
        this.set('ordinals', ordinals);
    }
});

// The measureCollection Model
directory.models.measureCollection = Backbone.Collection.extend({

    model: directory.models.measure,

    store: directory.utils.store,

    findByName: function(key) {
        this.reset(this.store.findByType(key));
    },

    findByType: function(key) {
        this.reset(this.store.findByType(key));
    }

});

directory.models.code = Backbone.Model.extend({
    defaults: {
        name: 'Enter a name'
    },

    initialize: function() {

    }
});

directory.models.codeCollection = Backbone.Collection.extend({
    model: directory.models.code,

    store: directory.utils.store,

    find: function() {
        this.reset(this);
    }
});

directory.models.ordinal = Backbone.Model.extend({
    defaults: {
        name: 'Enter a name'
    },

    comparator: 'order',

    initialize: function() {

    }
});

directory.models.ordinalCollection = Backbone.Collection.extend({
    model: directory.models.ordinal,

    store: directory.utils.store,

    find: function() {
        this.reset(this);
    }
});


// -------------------------------------------------- The Views ---------------------------------------------------- //

directory.views.SearchPage = Backbone.View.extend({

    initialize: function() {
        this.template = _.template(directory.utils.templateLoader.get('search-page'));
    },

    render: function(eventName) {
        $(this.el).html(this.template(this.model.toJSON()));
        this.listView = new directory.views.measureListView({el: $('ul.results', this.el), model: this.model});
        this.listView.render();
        return this;
    },

    events: {
        "click": "search"
    },

    search: function(event) {
        var key = $(event.srcElement).attr('data-val');
        if (key===undefined) return;
        this.model.findByType(key);
    }
});

directory.views.measureListView = Backbone.View.extend({

    initialize: function() {
        this.model.bind("reset", this.render, this);
    },

    render: function(eventName) {
        $(this.el).empty();
        _.each(this.model.models, function(measure) {
            $(this.el).append(new directory.views.measureListItemView({model: measure}).render().el);
        }, this);
        return this;
    }
});

directory.views.measureListItemView = Backbone.View.extend({

    tagName: "li",

    initialize: function() {
        this.template = _.template(directory.utils.templateLoader.get('measure-list-item'));
    },

    render: function(eventName) {
        $(this.el).html(this.template(this.model.toJSON()));
        return this;
    }

});

directory.views.measurePage = Backbone.View.extend({
    events : {
        "change input" :"changed",
        "click a.data-type" :"selectDataType",
        "click a.measure-type": "selectMeasureType"
    },
    initialize: function () {
        this.template = _.template(directory.utils.templateLoader.get('measure-page'));
        _.bindAll(this, "changed");
    },
    changed:function(evt) {
       var changed = evt.currentTarget;
       var value = $(evt.currentTarget).val();
       var obj = {};
       obj[changed.id] = value;
       this.model.set(obj);
    },
    render: function(eventName) {
        var js = this.model.toJSON();
        var tpl = this.template(js);
        $(this.el).html(tpl);
        return this;
    },
    dataTypeClass: function(dataType) {
        if (this.model.attributes.dataType.value == dataType.value)
            return "selected";
        return "";
    },
    measureTypeClass: function(measureType) {
        if (this.model.attributes.measureType.value == measureType.value)
            return "selected";
        return "";
    },
    selectDataType: function(evt) {
        $(".data-type").removeClass('selected');
        var selected = evt.currentTarget;
        var dataType = $(selected).addClass("selected").attr('data-val');
        this.model.dataType = DataTypes.get(dataType);
    },
    selectMeasureType: function(evt) {
        $(".measure-type").removeClass('selected');
        var selected = evt.currentTarget;
        var measureType = $(selected).addClass("selected").attr('data-val');
        this.model.measureType = MeasureTypes.get(measureType);
    }
});


directory.views.ordinalItemView = Backbone.View.extend({
    tagName: "li",

    initialize: function() {
        this.template = _.template(directory.utils.templateLoader.get('ordinal-item'));
    },

    render: function(eventName) {
        $(this.el).html(this.template(this.model.toJSON()));
        return this;
    }
});


directory.views.ordinalOptionsPage = Backbone.View.extend({
    
    events : {
        "click a.add-item" :"add"
    },
    initialize: function () {
        this.template = _.template(directory.utils.templateLoader.get('ordinal-options-page'));
        _.bindAll(this, "changed");
    },
    add: function() {
        var ordinal = new directory.models.ordinals();
        this.model.attributes.ordinals.add(ordinal);
    },
    render: function(eventName) {
        var js = this.model.toJSON();
        var tpl = this.template(js);
        $(this.el).html(tpl);
        return this;
    }
});

directory.views.codedItemView = Backbone.View.extend({
    tagName: "li",

    initialize: function() {
        this.template = _.template(directory.utils.templateLoader.get('coded-item'));
    },

    render: function(eventName) {
        $(this.el).html(this.template(this.model.toJSON()));
        return this;
    }
});

directory.views.codedItemListView = Backbone.View.extend({
    el: 'ul.code-list',
    initialize: function() {
        this.model.bind("reset", this.render, this);
    },
    add: function(code) {
        var li = new directory.views.codedItemView({model: code}).render().el;
        $("#code-list").append(li);
    },
    render: function(eventName) {
        $(this.el).empty();
        _.each(this.model.attributes.codes, function(code) {
            this.add(code);
        }, this);
        return this;
    }
});

directory.views.codedOptionsPage = Backbone.View.extend({
    events : {
        "click a.add-item" :"add"
    },
    initialize: function () {
        this.template = _.template(directory.utils.templateLoader.get('coded-options-page'));
        this.model.attributes.codes.bind('add', this.render);
        _.bindAll(this, "add");
    },
    add: function() {
        var code = new directory.models.code();
        this.model.attributes.codes.add(code);
    },
    render: function(eventName) {
        $(this.el).html(this.template(this.model.toJSON()));
        this.listView = new directory.views.codedItemListView({el: $('ul.codes', this.el), model: this.model});
        this.listView.render();
        return this;
    }
});

// ----------------------------------------------- The Application Router ------------------------------------------ //

directory.Router = Backbone.Router.extend({

    routes: {
        "": "list",
        "list": "list",
        "measures/:id": "measureDetails",
        "measures/:id/ordinaloptions": "ordinalOptions",
        "measures/:id/codedoptions": "codedOptions"
    },

    initialize: function() {

        var self = this;

        // Keep track of the history of pages (we only store the page URL). Used to identify the direction
        // (left or right) of the sliding transition between pages.
        this.pageHistory = [];

        this.store = directory.utils.store;

        // Register event listener for back button throughout the app
        $('#content').on('click', '.back-button', function(event) {
            directory.utils.store.saveMeasures();
            window.history.back();
            return false;
        });

        // Check of browser supports touch events...
        if (document.documentElement.hasOwnProperty('ontouchstart')) {
            // ... if yes: register touch event listener to change the "selected" state of the item
            $('#content').on('touchstart', 'a', function(event) {
                self.selectItem(event);
            });
            $('#content').on('touchend', 'a', function(event) {
                self.deselectItem(event);
            });
        } else {
            // ... if not: register mouse events instead
            $('#content').on('mousedown', 'a', function(event) {
                self.selectItem(event);
            });
            $('#content').on('mouseup', 'a', function(event) {
                self.deselectItem(event);
            });
        }

        // We keep a single instance of the SearchPage and its associated measure collection throughout the app
        this.searchResults = new directory.models.measureCollection();
        this.searchPage = new directory.views.SearchPage({model: this.searchResults});
        this.searchPage.render();
        $(this.searchPage.el).attr('id', 'searchPage');
    },

    selectItem: function(event) {
        $(event.target).addClass('tappable-active');
    },

    deselectItem: function(event) {
        $(event.target).removeClass('tappable-active');
    },

    list: function() {
        var self = this;
        this.slidePage(this.searchPage);
    },

    measureDetails: function(id) {
        var measure = new directory.models.measure({id: id}),
            self = this;
        measure.fetch({
            success: function(data) {
                self.slidePage(new directory.views.measurePage({model: data}).render());
            }
        });
    },

    ordinalOptions: function(id) {
        var measure = new directory.models.measure({id: parseInt(id)}),
        self = this;
        measure.fetch({
            success: function(data) {
                self.slidePage(new directory.views.ordinalOptionsPage({model: data}).render());
            }
        });
    },

    codedOptions: function(id) {
        var measure = new directory.models.measure({id: parseInt(id)}),
        self = this;
        measure.fetch({
            success: function(data) {
                self.slidePage(new directory.views.codedOptionsPage({model: data}).render());
            }
        });
    },

    slidePage: function(page) {

        var slideFrom,
            self = this;

        if (!this.currentPage) {
            // If there is no current page (app just started) -> No transition: Position new page in the view port
            $(page.el).attr('class', 'page stage-center');
            $('#content').append(page.el);
            this.pageHistory = [window.location.hash];
            this.currentPage = page;
            return;
        }

        // Cleaning up: remove old pages that were moved out of the viewport
        $('.stage-right, .stage-left').not('#searchPage').remove();

        if (page === this.searchPage) {
            // Always apply a Back (slide from left) transition when we go back to the search page
            slideFrom = "left";
            $(page.el).attr('class', 'page stage-left');
            // Reinitialize page history
            this.pageHistory = [window.location.hash];
        } else if (this.pageHistory.length > 1 && window.location.hash === this.pageHistory[this.pageHistory.length - 2]) {
            // The new page is the same as the previous page -> Back transition
            slideFrom = "left";
            $(page.el).attr('class', 'page stage-left');
            this.pageHistory.pop();
        } else {
            // Forward transition (slide from right)
            slideFrom = "right";
            $(page.el).attr('class', 'page stage-right');
            this.pageHistory.push(window.location.hash);
        }

        $('#content').append(page.el);

        // Wait until the new page has been added to the DOM...
        setTimeout(function() {
            // Slide out the current page: If new page slides from the right -> slide current page to the left, and vice versa
            $(self.currentPage.el).attr('class', 'page transition ' + (slideFrom === "right" ? 'stage-left' : 'stage-right'));
            // Slide in the new page
            $(page.el).attr('class', 'page stage-center transition');
            self.currentPage = page;
        });

    }

});

// Bootstrap the application
directory.utils.store.populate();
directory.utils.templateLoader.load(['search-page', 'ordinal-options-page', 'coded-options-page', 'measure-page', 'measure-list-item', 'coded-item', 'ordinal-item'],
    function() {
        directory.app = new directory.Router();
        Backbone.history.start();
    });