<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <div id="posts" class="">
                <PostForm
                :img="posts[Id].image"
                :id="this.$route.params.id"
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
                posts: [],
                comments: []
            };
        },
        methods: {

            async makePostRequest() {
                const axios = require('axios');
                const response = await axios("https://localhost:51427/api/Post/v1");
                const data = response.data;
                console.log(data);
                this.posts = data;
            },
            async makeCommentRequest() {
                const axios = require('axios');
                const response = await axios("https://localhost:51427/api/Comment/v1/findByPostId?Id=" + this.Id);
                const data = response.data;
                console.log(data);
                this.comments = data;
            }
        },
        created() {
            this.makePostRequest()
            this.makeCommentRequest()
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
