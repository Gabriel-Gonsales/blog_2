<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <div id="posts" class="">
                <div class="col-12 d-flex justify-content-around">
                    <router-link class="col-12 col-md-4 text-decoration-none text-danger" to="/CadastroPost">
                        <button class="btn btn-outline-none col-12 bg-white">
                            <b class="text-danger">Cadastro de posts</b>
                        </button>
                    </router-link>
                </div>
                <div class="">
                    <form>
                        <input class="search col-12 col-md-12 col-sm-12" placeholder="Pesquise posts" type="text" v-model.lazy="search" />
                        <hr id="linha"/>
                        <button class="text-danger col-12  col-sm-12 search bg-white" @click="achaTitulo(search)" type="submit">
                            <b>Pesquisar</b>
                        </button>
                    </form>
                </div>
                <PostBlog v-for="(post) in posts"
                          :key="post.id"
                          :idp="post.id"
                          :img="post.fileName"
                          :ttl="post.title"
                          :txt="post.description"
                          class="post" />
            </div>
            <div class="col-md-12 d-flex justify-content-around">
                <button @click="clickmenos()" class="text-danger btn btn-outline-none col-6 col-sm-4 col-md-2 bg-white" v-if="anterior">
                    <b>Anterior</b>
                </button>
                <button @click="clickmais()" class="text-danger btn btn-outline-none col-6 col-sm-4 col-md-2 bg-white" v-if="proximo">
                    <b>Próximo</b>
                </button>
            </div>

</b-container>
    </div>

</template>

<script>

import PostBlog from './components/Post.vue'

    export default {
        name: 'HomeSite',
        components: {
            PostBlog
        },
        data() {
            return {
                posts: [],
                pagina: localStorage.pagina,
                anterior: true,
                proximo: true,
                search: ''
            };
        },
        methods: {
            async achaTitulo() {
                const axios = require('axios');
                var response = null;
                response = await axios("https://localhost:51427/api/Post/v1/findPostByTitle?title=" + this.search);
                const data = response.data;
                console.log(data);
                this.posts = data;

                this.anterior = false;
                this.proximo = false;
            },
            clickmais(){
                this.pagina++;
                this.makeRequest();
            },
            clickmenos(){
                this.pagina--;
                this.makeRequest();
            },
            async makeRequest() {
                const axios = require('axios');     
                var response = null;
                response = await axios("https://localhost:51427/api/Post/v1/asc/5/"+this.pagina);
                const data = response.data;
                console.log(data);
                this.posts = data.list;

                this.pagina == 1?this.anterior = false : this.anterior = true;

                this.pagina * data.pageSize >= data.totalResults ? this.proximo = false : this.proximo = true;

                localStorage.setItem('pagina', this.pagina);
                console.log(localStorage.pagina);
                console.log(this.pagina);
            }

        },
        created() {
            this.makeRequest()
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
        margin-top: 2vh;
    }

    .btn{
        margin-top: 3vh;
        margin-bottom: 2vh;
    }
    .btn {
        --bs-btn-border-radius: 0rem;
    }
    .search{
        border: none;
        margin-right: 1vh;
        text-align: center;
    }
    #linha{
        margin: 0vh;
    }
</style>
