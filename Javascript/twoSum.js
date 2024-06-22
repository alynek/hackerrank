function twoSum(array, target){ 

    if(array.length > 1){

        for(let i = 0; i < array.length; i++){ // Time complexity: O(n)

            let numberToFind = target - array[i]
            if(numberToFind < 0){
                continue
            }
            else{
                for(let j = i + 1; j < array.length; j++){ // Time complexity: (n - (n - 1)) => (n-1)n / 2 => n^2 - n / 2 (remove constants) => O(n^2)
                    if(numberToFind == array[j]){
                        return [i, j]
                    }
                }
            }
        }
    }
    else{
        return null;
    }
}