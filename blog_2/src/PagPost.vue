<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <div id="posts" class="">
                <PostForm
                          :img="posts[Id].image"
                          :ttl="posts[Id].title"
                          :txt="posts[Id].description"
                          class="post" />
            </div>
        </b-container>
    </div>

</template>

<script>
    import PostForm from './components/PostFormulario.vue'

    export default {

        name: 'PagPost',
        components: {
            PostForm
        },
        data() {
            return {
                Id: this.$route.params.id,
                posts: []
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

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        color: #2c3e50;
        margin-top: 10px;
    }

    #posts {
        margin-bottom: 10vh;
        margin-top: 2vh;
    }

    .post {
        margin-bottom: 1vh;
        margin-top: 2vh;
    }
</style>
