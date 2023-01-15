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