<template>
    <div id="App">
        <input type="checkbox" id="jack" value="Jonas" v-model="checkedNames">
        <label for="jack">Jonas</label>
        <input type="checkbox" id="john" value="João" v-model="checkedNames">
        <label for="john">João</label>
        <input type="checkbox" id="mike" value="Miguel" v-model="checkedNames">
        <label for="mike">Miguel</label>
        <br>
        <span>Nomes assinalados: {{ checkedNames }}</span> <br>

        <select v-model="selected">
            <option disabled value="">Escolha um item</option>
            <option>A</option>
            <option>B</option>
            <option>C</option>
        </select>
        <br>
        <span>Selecionado: {{ selected }}</span>
        <br />
        <input type="radio" id="one" value="Um" v-model="picked">
        <label for="one">Um</label>
        <br>
        <input type="radio" id="two" value="Dois" v-model="picked">
        <label for="two">Dois</label>
        <br>
        <span>Escolhido: {{ picked }}</span>
        <br />
        <select v-model="selecionado" multiple>
            <option>A</option>
            <option>B</option>
            <option>C</option>
        </select>
        <br>
        <span>Selecionados: {{ selecionado }}</span>
        <br />
        <button v-on:click="count++">Você clicou em mim {{ count }} vezes.</button>
    </div>
</template>

<script>

    export default {
        name: 'ArrayNomes',
        props: {

        },
        data() {
            return {
                checkedNames: [],
                selecionado: [],
                selected: '',
                picked: '',
                count: 0
            }
        },
        methods: {

        },
        watch() { 
        }
    }

</script>


<style scoped>
    h3 {
      margin: 40px 0 0;
    }
    ul {
      list-style-type: none;
      padding: 0;
    }
    li {
      display: inline-block;
      margin: 0 10px;
    }
    a {
      color: #42b983;
    }
    #banner {
        margin-bottom: 12px;
        max-height: 20vh;
        padding-top: 13vh;
        padding-bottom: 8vh;
        background-image: radial-gradient(#5347b5,#2ddde0);
    }
    #post {
        margin-bottom: 12px;
        min-height: 40vh;
        padding-top: 0vh;
    }

    #titulo_banner{
        color: white;
    }

    #post-img {
        max-height: 20vh;
    }
</style>
