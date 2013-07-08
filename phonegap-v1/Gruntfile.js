module.exports = function(grunt) {

  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    concat: {
      options: {
        separator: ';'
      },
		web: {
			options: {
				sourceMap: 'js/bht-web.min.js.map',
				sourceMappingURL: function(path){
					return path.replace(/^js\//i, '') + '.map';
				},
				sourceMapRoot: '../',
				beautify: {
					max_line_len: 500
				}
			},
			files: {
				'js/bht-web.min.js': [
					'assets/js/libs/xui-2.3.2.js',
					'assets/js/libs/iscroll.js',
					'assets/js/libs/panes.js',
					'assets/js/libs/jquery.tinysort.js',
					//'js/index.js',
					'assets/js/libs/ruto.js',
					'assets/js/libs/amplify.store.js',
					'assets/js/libs/hogan.js',
					'assets/js/libs/hnapi.js',
					'assets/js/libs/ibento.js',
					'assets/js/libs/classList.js',
					'assets/js/templates.js',
					'assets/js/bht.js',
					'assets/js/bht-web.js'
				]
			}
		},
		ios: {
			options: {
				sourceMap: 'js/bht-ios.min.js.map',
				sourceMappingURL: function(path){
					return path.replace(/^js\//i, '') + '.map';
				},
				sourceMapRoot: '../',
				beautify: {
					max_line_len: 500
				}
			},
			files: {
				'js/bht-ios.min.js': [
					'assets/js/libs/xui-2.3.2.js',
					'assets/js/libs/iscroll.js',
					'assets/js/libs/panes.js',
					'assets/js/libs/jquery.tinysort.js',
					//'js/index.js',
					'assets/js/libs/ruto.js',
					'assets/js/libs/amplify.store.js',
					'assets/js/libs/hogan.js',
					'assets/js/libs/hnapi.js',
					'assets/js/libs/tappable.js',
					'assets/js/libs/tween.js',
					'assets/js/libs/requestanimationframe.js',
					'assets/js/templates.js',
					'assets/js/bht.js',
					'assets/js/bht-ios.js'
				]
			}
		}
    },
    uglify: {
      options: {
        banner: '/*! <%= pkg.name %> <%= grunt.template.today("dd-mm-yyyy") %> */\n'
      },
		web: {
			options: {
				sourceMap: 'js/bht-web.min.js.map',
				sourceMappingURL: function(path){
					return path.replace(/^js\//i, '') + '.map';
				},
				sourceMapRoot: '../',
				beautify: {
					max_line_len: 500
				}
			},
			files: {
				'js/bht-web.min.js': [
					'assets/js/libs/panes.js',
					'assets/js/libs/jquery.tinysort.js',
					//'js/index.js',
					'assets/js/libs/ruto.js',
					'assets/js/libs/amplify.store.js',
					'assets/js/libs/hogan.js',
					'assets/js/libs/hnapi.js',
					'assets/js/libs/ibento.js',
					'assets/js/libs/classList.js',
					'assets/js/templates.js',
					'assets/js/bht.js',
					'assets/js/bht-web.js'
				]
			}
		},
		ios: {
			options: {
				sourceMap: 'js/bht-ios.min.js.map',
				sourceMappingURL: function(path){
					return path.replace(/^js\//i, '') + '.map';
				},
				sourceMapRoot: '../',
				beautify: {
					max_line_len: 500
				}
			},
			files: {
				'js/bht-ios.min.js': [
					'assets/js/libs/xui-2.3.2.js',
					'assets/js/libs/iscroll.js',
					'assets/js/libs/panes.js',
					'assets/js/libs/jquery.tinysort.js',
					'js/index.js',
					'assets/js/libs/ruto.js',
					'assets/js/libs/amplify.store.js',
					'assets/js/libs/hogan.js',
					'assets/js/libs/hnapi.js',
					'assets/js/libs/tappable.js',
					'assets/js/libs/tween.js',
					'assets/js/libs/requestanimationframe.js',
					'assets/js/templates.js',
					'assets/js/bht.js',
					'assets/js/bht-ios.js'
				]
			}
		}
    },
    qunit: {
      files: ['test/**/*.html']
    },
    jshint: {
      files: ['gruntfile.js', 'src/**/*.js', 'test/**/*.js'],
      options: {
        // options here to override JSHint defaults
        globals: {
          jQuery: true,
          console: true,
          module: true,
          document: true
        }
      }
    },
    watch: {
      files: ['<%= jshint.files %>'],
      tasks: ['jshint', 'qunit']
    }
  });

  grunt.loadNpmTasks('grunt-contrib-uglify');
  grunt.loadNpmTasks('grunt-contrib-jshint');
  grunt.loadNpmTasks('grunt-contrib-qunit');
  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.loadNpmTasks('grunt-contrib-concat');

  grunt.registerTask('test', ['jshint', 'qunit']);

  //grunt.registerTask('default', ['jshint', 'qunit', 'concat', 'uglify']);
  grunt.registerTask('default', ['jshint', 'qunit', 'concat']);

};