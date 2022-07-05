<template>
<header>
<ul class = "navigation">
    <li class="items" v-for="link in Links">
        <a :href="link.link">{{link.name}}</a>
    </li>
</ul>
  </header>
</template>

<script>
export default {
    setup() {
        let Links = [
            {name : "Home", link :"#"},
            {name : "Kursübersicht", link :"#"},
            {name : "Kurs hinzufügen", link :"#"},
            {name : "Profil", link :"#"}
        ]
        return{Links}
    }
};
</script>

<style lang="css" scoped>

.navigation {
    background-color: var(--color-background-green);
    color: white; 
	max-width: 100%;
    padding: 10px;
    border-radius: 0 0 20px 20px;
}
li {
    display: inline-block; 
    padding: 0 40px 0 40px; 
	margin: .3em; 
	line-height: 2em; 
    max-height: 2em; 
}
.items a {
    text-decoration: none;
    list-style: none;
    color: white; 
}
</style>