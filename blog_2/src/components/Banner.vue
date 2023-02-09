<template>
    <div id="conteinerPrincipal">
        <h1 class="text-center " id="titulo">
            <b>{{titulo}}</b>
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
                titulo: this.ttl
            }

        }
    }

</script>


<style scoped>

    #conteinerPrincipal {
        background-image: url("https://png.pngtree.com/thumb_back/fw800/back_pic/05/05/72/6759687f9067428.jpg");
        padding-top: 10vh;
        padding-bottom: .5vh;
    }
    #ImagemContainer {
        max-height: 20vh;
        object-fit: cover;
    }

</style>
