<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <h2 class="text-danger"><b>Cadastro de posts</b></h2>
            <form class="" id="formulario" @submit="createPost()">
                <input v-model="titulo" id="titulo" placeholder="Escreva o título" class="col-12 col-sm-12 col-md-12" type="text" />
                <br /><br />
                <textarea v-model="descricao" id="descricao" placeholder="Escreva o conteúdo" class="col-12 col-sm-12 col-md-12"></textarea>
                <br /><br />
                <input v-model="imagem" id="imagem" placeholder="Link da imagem" class="col-12 col-sm-12 col-md-12" type="text" />
                <br /><br />
                <div class="d-flex justify-content-around">
                    <button type="submit" class="btn btn-danger col-md-4">Submit</button>
                </div>
            </form>
        </b-container>
    </div>

</template>

<script>

    export default {
        name: 'CadastroPost',
        components: {
        },
        data() {
            return {
                imagem: '',
                descricao: '',
                titulo: ''
            };
        },
        methods: {
            async createPost() {
                console.log("Criou!")

                const data = {
                    description: this.descricao,
                    title: this.titulo,
                    image: this.imagem
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
            }
        },
        created() {
        },
        watch: {

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
