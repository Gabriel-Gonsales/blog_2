<template>
    <b-container class="col-md-8" id="app">
        <div id="banner" class="bg-primary">
            <BannerBlog tll="Aparece titulo"/>
        </div>
        <div id="posts" class="">
            <PostBlog class="post" tll="Olá" txt="Oi" />
            <PostBlog class="post" tll="Olá" txt="Oi" />
        </div>
    </b-container>
</template>

<script>
    import PostBlog from './components/Post.vue'
    import BannerBlog from './components/Banner.vue'

export default {
  name: 'App',
        components: {
            PostBlog,
            BannerBlog
        }
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 10px;
    }

    #posts{
        margin-bottom: 10vh;
        margin-top: 2vh;
    }

    .post{
        margin-bottom: 1vh;
        margin-top: 2vh;
    }


</style>
