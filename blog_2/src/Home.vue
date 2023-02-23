<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <div id="posts" class="">
                <form>
                    <input class="col-md-6" type="text" v-model.lazy="search" />
                    <button class="col-md-2" @click="achaTitulo(search)" type="submit"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-search" viewBox="0 0 16 16">
    <path d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z" />
</svg></button>
                </form>
                <PostBlog v-for="(post) in posts"
                          :key="post.id"
                          :idp="post.id"
                          :img="post.image"
                          :ttl="post.title"
                          :txt="post.description"
                          class="post" />
            </div>
            <div class="col-md-12 d-flex justify-content-around">
                <button @click="clickmenos()" class="btn btn-outline-none col-md-2 bg-white" v-if="anterior">
                    Anterior
                </button>
                <button @click="clickmais()" class="btn btn-outline-none col-md-2 bg-white" v-if="proximo">
                        Próximo
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
                pagina: 1,
                anterior: true,
                proximo: true,
                search: ''
            };
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
            async makeRequest (){
                const axios = require('axios');     
                var response = null;
                response = await axios("https://localhost:51427/api/Post/v1/asc/5/"+this.pagina);
                const data = response.data;
                console.log(data);
                this.posts = data.list;

                this.pagina == 1?this.anterior = false : this.anterior = true;

                this.pagina*data.currentPage >= data.totalResults?this.proximo = false : this.proximo = true;
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
