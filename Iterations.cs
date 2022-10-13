using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation

           In each method below you will see instructions that detail the requirements
           the method must implement to make the test pass.

           To start on a method comment out, or remove, the line
           `throw new System.NotImplementedException();`

           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests
           continuously check your work each time you save. If a test is failing
           you have not yet completed that method. Once you finish a method and have
           it correct, the test will tell you how the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes a list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            List<string> yellingWords = words.Select(x => x.ToUpper()).ToList();
            //throw new System.NotImplementedException();
            return yellingWords;

        }


        // 
        // 2) Complete the method named `Double` that takes a list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            //throw new System.NotImplementedException();
            List<int> timesTwo = numbers.Select(x => x * 2).ToList();
            return timesTwo;

            /*return numbers.Select(x => x * 2).ToList();
            
            */
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes a list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> words)
        {
            //throw new System.NotImplementedException();
            List<string> addingToString = words.Select((word, index) => $"{word} is at index {index}").ToList();
            return addingToString;
        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts a list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> numbers)
        {
            //throw new System.NotImplementedException();

            List<int> evens = numbers.Where(numbers => numbers % 2 == 0).ToList();

            return evens;
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts a
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> numbers)
        {
            //throw new System.NotImplementedException();
            List<int> evenIndexes = numbers.Where((number, index) => index % 2 == 0).ToList();
            return evenIndexes;
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts a list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // new Movie() {
        //   Name: "Get Out",
        //   Year: "2017",
        //   Score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> movies, int yearToMatch)
        {
            //throw new System.NotImplementedException();
            List<string> goodMovies = movies.Where(movie => movie.Score >= 90 && movie.Year == yearToMatch).Select(movie => $"{movie.Name}").ToList<string>();

            return goodMovies;
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts a list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> numbers)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts a list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> sentences)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts a list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> sentences)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts a list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> words)
        {
            throw new System.NotImplementedException();
        }
    }
}
