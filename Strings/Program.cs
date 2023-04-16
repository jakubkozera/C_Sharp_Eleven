
using System.Text;

var life = "brutal";

string filename3 = $$$""""
c:\docume"""nts\fi
les\file
Life {{is}} {{{life}}}
{
    "name": "FirstName",
    "label": "First Name",
    "type": "Text",
    "required": true
}
"""";


var rating = 3;

var message = $"This course has rating of {rating}, which means it {rating switch
{
    < 3 => "sucks",
    _ => "not bad"
}}";



var oldEncoding = Encoding.UTF8.GetBytes("Some value");

var newEncoding = "Some value"u8.ToArray();

//var test = (message)u8;