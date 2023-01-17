var http = require("http");
const https = require('https');
var express = require('express');
var app = express();
var mysql      = require('mysql');
var bodyParser = require('body-parser');
const { error } = require("console");
const swaggerUI = require("swagger-ui-express")
const swaggerDocument = require('./swagger.json');
const { UTF8 } = require("mysql/lib/protocol/constants/charsets");
app.use("/api-docs", swaggerUI.serve, swaggerUI.setup(swaggerDocument));

var connection = mysql.createConnection({
  host     : 'localhost',
  user     : 'root', 
  database : 'szop_gyak' 
});
 
connection.connect(function(err) {
  if (err) throw err
  console.log('A csatlakozás sikerült...')
})


app.use( bodyParser.json() );       // to support JSON-encoded bodies
app.use(bodyParser.urlencoded({     // to support URL-encoded bodies
  extended: true
}));

var server = app.listen(3000,  "127.0.0.1", function () {
 
  var host = server.address().address
  var port = server.address().port
 
  console.log("Figyeljük a következő URI-t http://%s:%s", host, port)
 
});

app.get('/termek', function (req, res) {
   connection.query('select * from termek', function (error, results, fields) {
	  if (error) throw error;
		  //res.end(JSON.stringify(results)); // ez nem megy, a res.end nem állít be megfelelő header-t!!
		  res.json(results);

	});
});

app.get("/termek/:id", function (req, res) {
	//console.log(req);
	connection.query(
	  "select * from termek where id=?",
	  [req.params.id],
	  function (error, results, fields) {
		if (results.length === 0)
			res.sendStatus(400);
		else 
			res.json(results);
	  }
	);
  });
