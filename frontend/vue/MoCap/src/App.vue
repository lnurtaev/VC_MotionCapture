<script setup>
import { RouterLink, RouterView } from "vue-router";

</script>

<template>
  <header>
    <ul class="navigation">
      <div class="icon">
        <h2 class="logo"> Mocap</h2>
      </div>
      <div class="test">
        <li class="items">
          <RouterLink to="/">Kursübersicht</RouterLink>
        </li>
        <li class="items">
          <RouterLink to="/profil">Profil</RouterLink>
        </li>
      </div>
    </ul>
  </header>
  <main>
    <RouterView />
  </main>
</template>

<style>
@import './assets/base.css';

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

.test :hover {
  background-color: var(--seagreen);
}

.icon {
  width: 200px;
  float: left;
}
</style>