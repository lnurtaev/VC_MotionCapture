<template>
<header>
<ul class = "navigation">
    <div class="test">
    <li class="items" v-for="link in Links">
        <a :href="link.link">{{link.name}}</a>
    </li>
    </div>
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
    border-radius: 0 0 20px 20px;
}
li {
    display: inline-block; 
    padding: 0px 40px 0px 40px; 
	line-height: 3em; 
    height: 3em;
    }
.items a {
    text-decoration: none;
    list-style: none;
    color: white; 
}
li.items :hover {
    text-decoration: none; 
    font-weight: bold;
    }
.test :hover{
    background-color: var(--seagreen);
}
</style>