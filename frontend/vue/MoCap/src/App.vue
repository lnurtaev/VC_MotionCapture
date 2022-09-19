<script setup>
import { RouterLink, RouterView } from "vue-router";

</script>

<template>
  <header>
    <ul class="navigation">
      <div class="icon">
        <h2 class="logo">Mocap</h2>
      </div>
      <div class="items">
        <RouterLink to="/">
          <li class="item">
            Kursübersicht
          </li>
        </RouterLink>

        <RouterLink to="/profil">
          <li class="item">Profil</li>
        </RouterLink>

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
  background-color: var(--primary);
  width: 100%;
}

li {
  display: inline-block;
  padding: 0px 40px 0px 40px;
  line-height: 4em;
  height: 4em;
  color: white;
}

.item a {
  text-decoration: none;
  list-style: none;
  color: white;
}

li.item :hover {
  text-decoration: none;
}

.items :hover {
  background-color: var(--primary-70);
  color: var(--black);
}

.icon {
  width: 200px;
  float: left;
  margin: 0.5em;
  color: var(--white);
}
</style>