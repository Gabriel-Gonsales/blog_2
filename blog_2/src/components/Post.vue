<template>
    <div id="conteinerPrincipal">
        <div id="contentImg">
            <img class="col-md-12" id="ImagemContainer" v-bind:src="imagem" />
        </div>
        <div class="bg-warning" id="contentTxt">
            <h2 id="titulo">
                {{titulo}}
            </h2>
            <p id="texto">
                {{texto}}
            </p>
        </div>
    </div>
</template>

<script>

    export default {
        name: 'PostBlog',
        props: {
            img: String,
            ttl: String,
            txt: String
        },
        data() {
            return {
                imagem: 'https://png.pngtree.com/thumb_back/fh260/background/20190222/ourmid/pngtree-simple-beige-banner-background-material-backgroundsimpleposter-backgroundbanner-backgroundbackground-image_51299.jpg',
                titulo: 'Título legal',
                texto: 'Textinho legal também'
            }

        }
    }

</script>


<style scoped>

    #conteinerPrincipal {
    }

    #contentImg{

    }

    #ImagemContainer{
        max-height: 20vh;
        min-width: 100vh;

    }

    #contentTxt {

    }
</style>
