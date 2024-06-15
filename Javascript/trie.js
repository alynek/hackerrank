class TrieNode{
    trieNoFilho = [];
    letra = null;
    
    constructor(letra){
        this.letra = letra
        finalPalavra: false,
        this.iniciaTrieNode()
    }
    iniciaTrieNode(){
        for(let i = 0 ; i < 26; i++){
            this.trieNoFilho[i] = null
        }
    }
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
        }
    }

    noAtual.finalPalavra = true
}

function buscarPalavra(noAtual, palavra){

    let posicaoCharCode = 97

    for(let p of palavra){
        let indiceLetra = p.charCodeAt() - posicaoCharCode

        if(noAtual.trieNoFilho[indiceLetra] != null){

            noAtual = noAtual.trieNoFilho[indiceLetra]
        }
        else{
            return false;
        }
    }
    return true;
}


let no = new TrieNode()
insere(no, 'abacate')
buscarPalavra(no, 'abacate')
buscarPalavra(no, 'aba')
buscarPalavra(no, 'abacaxi')

insere(no, 'abacaxi')
buscarPalavra(no, 'abacaxi')