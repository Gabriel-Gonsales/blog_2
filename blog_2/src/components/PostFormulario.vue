<template>
    <div>
        <div class="bg-light" id="postG">
            <div id="contentImg">
                <img class="col-12" id="ImagemContainer" :src="imagem" />
            </div>
            <b-container class="col-md-10">
                <div class="" id="textos">
                    <h3 class="text-danger" id="titulo">
                        <b>{{titulo}}</b>
                    </h3>
                    <p id="texto">
                        {{texto}}
                    </p>
                </div>
            </b-container>
        </div>
        <div class="bg-light">
            <b-container class="col-md-10">
                <div id="coments" class="">
                    <h2 class="text-danger">
                        <b>Deixe seu comentário</b>
                    </h2>
                    <form id="formulario">
                        <input v-model="nome" id="name" placeholder="Seu nome" class="col-md-12" type="text" />
                        <br /><br />
                        <textarea v-model="comentario" id="coment" placeholder="Deixe aqui seu comentário" class="col-md-12"></textarea>
                        <div class="d-flex justify-content-end">
                            <button type="submit" class="btn btn-danger col-md-4">Submit</button>
                        </div>
                    </form>
                    <br />
                    <p class="text-danger">
                        <b class="text-uppercase">{{nome}}</b> em {{data}}
                    </p>
                    <p class="text-break text-justify">
                        {{comentario}}
                    </p>
                </div>
            </b-container>
        </div>

    </div>

</template>

<script>

    export default {
        name: 'PostForm',
        props: {
            img: String,
            ttl: String,
            txt: String
        },
        data() {
            return {
                imagem: this.img,
                titulo: this.ttl,
                texto: this.txt,
                comentario: 'Deixe aqui seu comentário',
                nome: 'Seu nome',
                data: '08/02/2023'
            }
        },
        methods: {
            /*makeRequest() {
                var axios = require('axios');
                var data = '';

                var config = {
                    method: 'get',
                    maxBodyLength: Infinity,
                    url: 'https://localhost:51427/api/Post/v1/asc/5/1',
                    headers: {
                        'Accept': 'text/plain'
                    },
                    data: data
                };

                axios(config)
                    .then(function (response) {
                        response => this.posts = JSON.stringify(response.data);
                        console.log(JSON.stringify(response.data));

                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            }*/

            async makeRequest() {
                const axios = require('axios');
                const response = await axios("https://localhost:51427/api/Post/v1");
                const data = response.data;
                console.log(data);
                console.log(data[0]);
                this.posts = data;
            }
        },
        created() {
            this.makeRequest()
        }
    }

</script>


<style scoped>

    #ImagemContainer {
        min-width: 50vw;
    }

    #textos {
        margin-top: 2vh;
        text-align: justify;
    }

    #formulario{
        margin-top: 2vh;
    }

    #postG{
        padding-bottom: 2vh;
        margin-bottom: 1vh;
    }

    #coments {
        padding-top: 2vh;
        text-align: justify;
        margin-bottom: 10vh;
        padding-bottom: 10vh;
    }


    #name{
        height: 5vh;
    }
    #coment{
        height: 15vh;
    }

    .btn {
        --bs-btn-border-radius: 0rem;
    }
</style>
