document.getElementById('formulario').addEventListener('submit', function (e) {
    e.preventDefault();
    document.getElementById('tabela-dados').classList.remove('d-none');
    
    document.getElementById('t-nome').innerText = document.getElementById('nome').value;
    document.getElementById('t-sobrenome').innerText = document.getElementById('sobrenome').value;
    document.getElementById('t-email').innerText = document.getElementById('email').value;
    document.getElementById('t-login').innerText = document.getElementById('login').value;
    document.getElementById('t-senha').innerText = document.getElementById('senha').value;
    document.getElementById('t-cep').innerText = document.getElementById('cep').value;
    document.getElementById('t-endereco').innerText = document.getElementById('endereco').value;
    document.getElementById('t-complemento').innerText = document.getElementById('complemento').value;
    document.getElementById('t-bairro').innerText = document.getElementById('bairro').value;
    document.getElementById('t-cidade').innerText = document.getElementById('cidade').value;
    document.getElementById('t-estado').innerText = document.getElementById('estado').value;
    document.getElementById('t-perfilGit').innerText = document.getElementById('perfilGit').value;
    document.getElementById('t-academia').innerText = document.getElementById('academia').value;
    document.getElementById('t-professor').innerText = document.getElementById('professor').value;
    document.getElementById('t-aceite').innerText = document.getElementById('aceite').checked
    document.getElementById('t-informativos').innerText = document.getElementById('informativos').checked;
    
    alert('Informações submetidas!');
    
});

document.getElementById('nome').addEventListener('keyup', gerarLogin);
document.getElementById('sobrenome').addEventListener('keyup', gerarLogin);

function gerarLogin(){
const nome = document.getElementById('nome').value;
const sobrenome = document.getElementById('sobrenome').value;
const login = nome + '.' + sobrenome;
document.getElementById('login').value = login.toLowerCase();
}

document.getElementById('cep').addEventListener('focusout', function () {
    
    const cep = document.getElementById('cep').value;
    
    fetch(`https://viacep.com.br/ws/${cep}/json/`)
    .then((response) => {
        if (response.status >= 200 && response.status <= 299) {
            return response.json();
          } else {
            throw Error(response.statusText);
        }
    })
    .then((jsonResponse) => {  
        document.getElementById('endereco').value = jsonResponse.logradouro;
        document.getElementById('complemento').value = jsonResponse.complemento;
        document.getElementById('bairro').value = jsonResponse.bairro;
        document.getElementById('cidade').value = jsonResponse.localidade;
        document.getElementById('estado').value = jsonResponse.uf;
    })
    .catch((error) => {
        alert(error + "Ops, algo deu errado, verifique o CEP informado")
    })});