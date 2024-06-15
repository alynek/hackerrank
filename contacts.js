class TrieNode{
    trieNoFilho = [];
    letra = null;
    
    constructor(letra){
        this.letra = letra
        this.finalPalavra = false
        this.quantidadePalavras = 1
        this.iniciaTrieNode()
    }
    iniciaTrieNode(){
        for(let i = 0 ; i < 26; i++){
            this.trieNoFilho[i] = null
        }
    }
}

function contacts(queries) {

    let no = new TrieNode()
    let resultado = []
 
    for(let i = 0; i < queries.length; i++){
          
        let adicionar = queries[i][0] === 'add'
        let buscar = queries[i][0] === 'find'

        let palavra = queries[i][1]

        if(adicionar){
            insere(no, palavra)
        }
        else if (buscar){
            resultado.push(buscarTotalPalavras(no, palavra))
        }
       
    }
    return resultado
}

function buscarTotalPalavras(no, palavra){

    let noAtual = no
    let posicaoCharCode = 97

    for(let p of palavra){
        if(noAtual.trieNoFilho[p.charCodeAt() - posicaoCharCode] != null){
            noAtual = noAtual.trieNoFilho[p.charCodeAt() - posicaoCharCode]
        }else{
            return 0
        }
    }
    return noAtual.quantidadePalavras
}

function insere(noAtual, palavra){

    let posicaoCharCode = 97
        
    for(let p of palavra){

        let indiceLetra = p.charCodeAt() - posicaoCharCode

        if(noAtual.trieNoFilho[indiceLetra] == null){

            let novoNo = new TrieNode(p)
            noAtual.trieNoFilho[indiceLetra] = novoNo

            noAtual = novoNo
        }
        else{
            noAtual = noAtual.trieNoFilho[indiceLetra]
            noAtual.quantidadePalavras++
        }
    }
    noAtual.finalPalavra = true
}


//let no = new TrieNode()