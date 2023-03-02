<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <h2 class="text-danger"><b>Cadastro de posts</b></h2>
            <form class="" id="formulario" @submit="createPost()">
                <input required v-model="titulo" id="titulo" placeholder="Escreva o título" class="form-control col-12 col-sm-12 col-md-12" type="text" />
                <br />
                <textarea required v-model="descricao" id="descricao" placeholder="Escreva o conteúdo" class="form-control col-12 col-sm-12 col-md-12"></textarea>
                <br />
                <input required class="form-control" type="file" @change="selecionaArq"/>
                <div class="d-flex justify-content-around">
                    <button type="submit" class="btn btn-danger col-md-4">Submit</button>
                </div>
            </form>
        </b-container>
    </div>

</template>

<script>
import axios from "axios";
    

    export default {
        name: 'CadastroPost',
        components: {
        },
        data() {
            return {
                imagem: '',
                descricao: '',
                titulo: '',
                enabled: 1,
                arquivo: null,
                arquivos: [],
                arqNome: '',
                fileByteArray: []
            };
        },
        methods: {
            /*readFile(file) {
                return new Promise((resolve, reject) => {
                    // Create file reader
                    let reader = new FileReader()

                    // Register event listeners
                    reader.addEventListener("loadend", e => resolve(e.target.result))
                    reader.addEventListener("error", reject)

                    // Read file
                    reader.readAsArrayBuffer(file)
                })
            },*/

            /*async getAsByteArray(file) {
                return new Uint8Array(await this.readFile(file))
            },*/

            async createPost() {
                let fd = new FormData();


                console.log(this.arquivos)           
                if (this.arquivos.length > 1) {
                    console.log(this.arquivos)
                    fd.append('file', this.arquivos)
                    axios.post('https://localhost:51427/api/File/v1/uploadMultipleFiles', fd, {
                        onUploadProgress: uploadEvent => {
                            console.log('Progresso: ' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%')
                        }
                    }).then(res => {
                        console.log(res)
                    });
                    this.arquivos = null;
                }
                else {
                    this.arqNome = this.arquivo.name;
                    console.log(this.arqNome);
                    fd.append('file', this.arquivo, this.arquivo.name)
                    axios.post('https://localhost:51427/api/File/v1/uploadFile', fd, {
                        onUploadProgress: uploadEvent => {
                            console.log('Progresso: ' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%')
                        }
                    }).then(res => {
                        console.log(res)
                    });
                    this.arquivo = null;
                }

                //const byteFile = await this.getAsByteArray(this.arquivo)
                //this.fileByteArray = await byteFile

                //console.log(this.byteFile)

                const data = {
                    description: this.descricao,
                    title: this.titulo,
                    enabled: this.enabled,
                    fileName: this.arqNome
                    //arquivo: this.fileByteArray
                }
                const dataJSON = JSON.stringify(data);
                console.log(dataJSON);
                const response = await fetch("https://localhost:51427/api/Post/v1", {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: dataJSON
                });
                const res = await response.json();
                console.log(res);

                this.imagem = '';
                this.descricao = '';
                this.titulo = '';


            },
            selecionaArq(event) {
                console.log(event.target.files);
                console.log(event.target.files.length)

                if (event.target.files.length > 1) {
                    for (var i = 0; i < event.target.files.length; i++) {
                        let file = event.target.files[i];
                        console.log(file);
                        this.arquivos[i] = file;
                    }
                }
                else{
                    let file = event.target.files[0];
                    this.arquivo = file;
                }
                console.log(this.arquivos);
                console.log(this.arquivos.length);
            },
        }
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        color: #2c3e50;
        margin-top: 10px;
    }

    #posts{
        margin-top: 2vh;
    }

    .post{
        margin-bottom: 1vh;
        margin-top: 2vh;
    }

    .btn{
        margin-top: 3vh;
        margin-bottom: 2vh;
    }
    .btn {
        --bs-btn-border-radius: 0rem;
    }
</style>
