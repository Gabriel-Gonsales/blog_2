<template>
    <div id="fundo" class="col-md-12">
        <b-container class="col-md-8" id="app">
            <div id="posts" class="">
                <PostBlog v-for="(post, index) in posts"
                          :key="index"
                          :id="post.idPost"
                          :img="post.imagem"
                          :ttl="post.titulo"
                          :txt="post.texto"
                          class="post" />
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
                posts: [
                    {
                        idPost: '0',
                        imagem: "images/parque.jpg",
                        titulo: "Parque das sequoias",
                        texto: "A Sequoia sempervirens, é popularmente chamada de sequoia sempre verde, chega a mais de 90 metros de altura, aproximadamente o mesmo que um edifício de 30 andares. Os galhos mais baixos ficam a 45 metros de distância do chão e seu tronco pode chegar a medir 3 metros de diâmetro. A coloração desta árvore pode variar entre o castanho-avermelhado e o castanho-canela, sua casca pode possuir em média de 15 a 30 cm e sulcos profundos. Nos últimos anos esta espécie tem sido plantada no sul do Brasil para fins ornamentais. Um exemplar da espécie foi apelidada de Hyperion, a maior árvore do mundo, que foi descoberta em 2006 em São Francisco, medindo 115,55 metros."
                    },
                    {
                        idPost: '1',
                        imagem: "images/pandinha.jpg",
                        titulo: "Os pandas vermelhos",
                        texto: "O panda-vermelho (Ailurus fulgens), também conhecido como panda-pequeno, raposa-de-fogo ou gato-de-fogo, é um pequeno mamífero arborícola, sendo a única espécie existente do gênero Ailurus. Este animal pertence à família Ailuridae, mas já foi classificado como sendo das famílias Procyonidae (guaxinim) e Ursidae (ursos)."
                    },
                    {
                        idPost: '2',
                        imagem: "images/bootstrap.png",
                        titulo: "O tal do Bootstrap",
                        texto: "Crie projetos responsivos para dispositivos móveis na web com a biblioteca de componentes front-end mais popular do mundo.O Bootstrap é uma ferramenta gratuita para desenvolvimento HTML, CSS e JS.Crie protótipos rápidamente ou aplicações completas com nossas variáveis e mixins Sass, sistemas de grid responsivo, componentes pré- construídos e poderosos plugins com jQuery."
                    }
                ]
            };
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
