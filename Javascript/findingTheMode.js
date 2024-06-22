/*
PROBLEM : FINDING THE MODE
In statistics, the mode of a set of values is the value that appears most often. Write
code that processes an array of survey data, where survey takers have responded to
a question with a number in the range 1–10, to determine the mode of the data set.
For our purpose, if multiple modes exist, any may be chosen.

Input: {4, 7, 3, 8, 9, 7, 3, 9, 9, 3, 3, 10}
Output: 3

Input: {1, 2, 9, 10, 7}
Output: 1

Input: {5}
Output: 5
*/

function findingTheMode(array){
    let modes = {
        'higherNumber': 0
    }
    
    for(let i = 0; i < array.length; i++){ //Time complexity: O(n)

        let number = array[i]
        let valueHigherNumber = modes['higherNumber']

        if(modes[number]){
            modes[number] ++

            if(modes[number] > modes[valueHigherNumber]){
                modes['higherNumber'] = number
            }
        }
        else{
            modes[number] = 1

            if(modes['higherNumber'] == 0){
                modes['higherNumber'] = number
            }
        }
    }
    return modes['higherNumber']
}