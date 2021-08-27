<template>
   <div v-bind:style="{ color: color}">Hello {{msg}}</div>
</template>
<script>export default {
        data() {
            return {
                msg: 'world!',
                color: 'blue',
            }
        }
    }</script>

<style scoped>
    
</style>
