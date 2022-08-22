<!--<template>
    <div class="files">
        HIER<p class="has-placeholder">Placeholder</p>
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
-->
<template>
<div id='file'>
 
  <!-- Select All records -->
  <input type='button' @click='allRecords()' value='Select All users'>
  <br><br>

  <!-- List records -->
  <table border='1' width='80%' style='border-collapse: collapse;'>
    <tr>
      <th>Kursid</th>
      <th>Name</th>
      <th>Bild</th>
    </tr>

    <tr v-for='kurs in kurse'>
      <td>{{ kurs.kurs_id }}</td>
      <td>{{ kurs.kurs_name }}</td>
      <td>{{ kurs.kurs_bild }}</td>
    </tr>
  </table>
 
</div>
</template>

<script>
var app = new Vue({
  el: 'file',
  data: {
    kurse: "",
  },
  methods: {
    allRecords: function(){

      axios.get('./../../../../backend/ajaxfile.php')
      .then(function (response) {
         app.kurse = response.data;
      })
      .catch(function (error) {
         console.log(error);
      });
    }
  }
})
    </script>

