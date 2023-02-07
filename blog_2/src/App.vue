<template>
    <b-container class="col-md-8" id="app">
        <div id="post" class="bg-primary">
            <InverterMsg message="" />
        </div>
        <div class="bg-warning">
            <ArrayNomes message="" />
        </div>
        <div class="bg-warning">
            <BlogPost/>
        </div>
    </b-container>
</template>

<script>
    import InverterMsg from './components/Inverter.vue'
    import ArrayNomes from './components/Formulario.vue'
    import BlogPost from './components/Padroes.vue'

export default {
  name: 'App',
        components: {
            InverterMsg,
            ArrayNomes,
            BlogPost
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

</style>
