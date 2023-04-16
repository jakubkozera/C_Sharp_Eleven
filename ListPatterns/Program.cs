// See https://aka.ms/new-console-template for more information

int[] numbers = { 1, 2, 3 };

var pattern1 = numbers is not [1, 2, 3];
var pattern2 = numbers is [1, 2];
var pattern3 = numbers is [_, 2, 3];
var pattern4 = numbers is [_, 2, > 2 and < 5];

Console.WriteLine($""""
numbers is [1, 2, 3]; == {pattern1}
numbers is [1, 2]; == {pattern2}
numbers is [_, 2, 3];  == {pattern3}
numbers is [_, 2, > 2 and < 5 ]; == {pattern4}

"""");

var numbers2 = new List<int> { 1, 2, 3, 4, 5 };

var pattern2_1 = numbers2 is [1, 2, ..];
var pattern2_2 = numbers2 is [.., 4, 5];
var pattern2_3 = numbers2 is [1, .., 5];

Console.WriteLine($$"""
numbers2 = new List<int>{ 1, 2, 3, 4, 5 };

pattern2_1 = numbers2 is [1, 2, ..]; = {{pattern2_1}}
pattern2_2 = numbers2 is [.., 4, 5]; = {{pattern2_2}}
pattern2_3 = numbers2 is [1, .., 5]; = {{pattern2_3}}
""");
