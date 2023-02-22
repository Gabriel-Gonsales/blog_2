<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <div id="posts" class="">
                <PostBlog v-for="(post, index) in posts"
                          :key="index"
                          :idp="post.id"
                          :img="post.image"
                          :ttl="post.title"
                          :txt="post.description"
                          class="post" />
            </div>
        </b-container>
    </div>

</template>

<script>
    import PostBlog from './components/Post.vue'
    import axios from "axios"

    export default {
        name: 'HomeSite',
        components: {
            PostBlog
        },
        data() {
            return {
                posts: {},
            };
        },
        methods: {
            getPost() {
                axios
                    .get("https://localhost:51427/api/Post/v1/asc/5/1")
                    .then((res) => {
                        this.user = res.data;
                    })
                    .catch((error) => {
                        console.log(error);
                    })
                    ;
            }
        },
        created() {
           this.getPost()
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

    #fundo{
        
    }
</style>
