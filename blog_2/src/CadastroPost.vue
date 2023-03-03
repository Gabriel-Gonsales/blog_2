<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <h2 class="text-danger"><b>Cadastro de posts</b></h2>
            <form class="" id="formulario" @submit="createPost()">
                <input required v-model="titulo" id="titulo" placeholder="Escreva o título" class="form-control col-12 col-sm-12 col-md-12" type="text" />
                <br />
                <textarea-autosize required v-model="descricao" id="descricao" placeholder="Escreva o conteúdo" class="form-control col-12 col-sm-12 col-md-12"></textarea-autosize>
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
    import profiles from '../../18_RestWithASPNETUdemy_UploadAndDownloadFiles/RestWithASPNETUdemy/RestWithASPNETUdemy/Properties/launchSettings.json'

    

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
                json: profiles.profiles.RestWithASPNETUdemy.applicationUrl.split(";")
            };
        },
        methods: {
            async createPost() {
                let fd = new FormData();

                console.log(this.arquivos)           
                if (this.arquivos.length > 1) {
                    console.log(this.arquivos)
                    fd.append('file', this.arquivos)
                    axios.post(this.json[0] + '/api/File/v1/uploadMultipleFiles', fd, {
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
                    axios.post(this.json[0] + '/api/File/v1/uploadFile', fd, {
                        onUploadProgress: uploadEvent => {
                            console.log('Progresso: ' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%')
                        }
                    }).then(res => {
                        console.log(res)
                        console.log(res.status)
                    });
                    this.arquivo = null;
                }

                const data = {
                    description: this.descricao,
                    title: this.titulo,
                    enabled: this.enabled,
                    fileName: this.arqNome
                }
                const dataJSON = JSON.stringify(data);
                console.log(dataJSON);
                const response = await fetch(this.json[0] + "/api/Post/v1", {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: dataJSON
                })
                const res = await response.json();
                console.log(res);

                this.$alert("Post cadastrado com sucesso!");

                this.imagem = '';
                this.descricao = '';
                this.titulo = '';

                this.$router.push({ name: 'Home' });

            },
            selecionaArq(event) {

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
            }
        },
        created() {
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
