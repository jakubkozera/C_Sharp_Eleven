using System;
using System.Text;

var life = "brutal";
var stringLiteral = $$""""
    tes
    test
    {
        "name": "FirstName",
        "label": "First Name",
        "type": "Text",
        "required": true
    }
    """Life is {{life}}"""
    """";

Console.WriteLine(stringLiteral);

var rating = 3;

var message = $"This course has rating of {rating}, which means its {rating switch
{
    < 3 => "sucks",
    _ => "not bad"
}}";

Console.WriteLine(message);

var oldEncoding = Encoding.UTF8.GetBytes("Some value");

var newEncoding = "Some value"u8.ToArray();