<template>
    <div id="fundo" class="">
        <b-container id="banner" class="items col-8">
            <BannerBlog ttl="Blog do Gabu" />
        </b-container>
        <router-view></router-view>
        <b-container id="banner" class="items col-8">
            <FooterBlog ttl="Blog do Gabu" />
        </b-container>
    </div>

</template>

<script>
    import BannerBlog from './components/Banner.vue'
    import FooterBlog from './components/Footer.vue'

    export default {
        name: 'App',
        components: {
            BannerBlog,
            FooterBlog
        },

    }
</script>

<style>
    #fundo{
        align-content: center;
    }
</style>
