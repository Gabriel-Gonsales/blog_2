<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <h2 class="text-danger"><b>Cadastro de posts</b></h2>
            <form class="" id="formulario" @submit="createPost()">
                <input required v-model="titulo" id="titulo" placeholder="Escreva o título" class="form-control col-12 col-sm-12 col-md-12" type="text" />
                <br />
                <textarea required v-model="descricao" id="descricao" placeholder="Escreva o conteúdo" class="form-control col-12 col-sm-12 col-md-12"></textarea>
                <br />
                <input required v-model="imagem" id="imagem" placeholder="Link da imagem" class="form-control col-12 col-sm-12 col-md-12" type="text" />
                <br />
                <input v-model="VF" class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                <label class="form-check-label text-center" for="flexCheckDefault">
                    Inserir arquivo
                </label>
                <br /><br />
                <input class="form-control" v-if="VF" type="file" @change="selecionaArq" />
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
                arquivo: null,
                VF: false,
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
                if (this.VF) {
                    const fd = new FormData();
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
                    image: this.imagem,
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
                this.arquivo = event.target.files[0];
                console.log(this.arquivo);
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
