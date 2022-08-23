var express = require('express');

var router = express.Router();

var database = require('../database');

router.get("/", function(request, response, next){

	var query = "SELECT * FROM db.kurs";

	database.query(query, function(error, data){

		if(error)
		{
			throw error; 
		}
		else
		{
			response.render('kursuebersicht', {title:'Test', action:'list', sampleData:data});
		
		}

	});

});

module.exports = router;