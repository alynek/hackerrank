function findingTheMode(array){
    let modes = {
        'higherNumber': 0
    }
    
    for(let i = 0; i < array.length; i++){

        let number = array[i]
        let valueHigherNumber = modes['higherNumber']

        if(modes[number]){
            modes[number] ++

            if(modes[number] > valueHigherNumber){
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