<template>
    <div class="files">
        <!--<p class="has-placeholder">Placeholder</p>-->
        <div class="has-placeholder" v-for="obj in Obj">
        <p>Placeholder {{obj.name}}</p>
    </div>
    </div>
</template>

<script>
export default {
    setup() {
        let Obj = [
            {name : "1"},
            {name : "2"},
            {name : "3"},
            {name : "4"}
        ]
        return{Obj}
    }
};
</script>

<style lang="css" scoped>
 
.files {
    width: 40%;
}

.has-placeholder {
margin: 30px;
  background-color: var(--almond);
  border-color: var(--black);
  border-width: 0.1em;
  border-radius: 20px;
  width: 180px;
  height: 90px;
  text-align: center;
}

</style>