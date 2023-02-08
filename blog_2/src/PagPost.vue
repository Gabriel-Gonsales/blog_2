<template>

    <div id="fundo" class="col-md-12">
        <router-view></router-view>
        <b-container class="col-md-8" id="app">
            <div id="banner" class="bg-primary">
                <BannerBlog ttl="Aparece título" />
            </div>
            <div id="posts" class="">

            </div>
        </b-container>
    </div>

</template>

<script>
export default {
  name: 'PagPost',
        components: {
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
        margin-bottom: 10vh;
        margin-top: 2vh;
    }

    .post{
        margin-bottom: 1vh;
        margin-top: 2vh;
    }
</style>
