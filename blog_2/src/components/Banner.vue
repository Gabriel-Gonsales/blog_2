<template>
    <div id="conteinerPrincipal">
        <h1 id="titulo">
            {{titulo}}
        </h1>
    </div>
</template>

<script>

    export default {
        name: 'BannerBlog',
        props: {
            ttl: String
        },
        data() {
            return {
                titulo: 'Título legal'
            }

        }
    }

</script>


<style scoped>

    #conteinerPrincipal {
        background-image: url("https://png.pngtree.com/thumb_back/fh260/background/20190222/ourmid/pngtree-simple-beige-banner-background-material-backgroundsimpleposter-backgroundbanner-backgroundbackground-image_51299.jpg");
    }

    #contentImg{

    }

    #ImagemContainer{
        max-height: 20vh;

    }

    #contentTxt {

    }
</style>
