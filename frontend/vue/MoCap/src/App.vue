<script setup>
import VideoPlayer from './components/VideoPlayer.vue'
import Navigation from './components/Navigation.vue'
import Filesystem from './components/Filesystem.vue';
</script>

<template>
  <header>
    <Navigation></Navigation>
  </header>

  <main>
    <div class="grid-layout">
      <div class="box1">
        <Filesystem></Filesystem>
      </div>
      <div class="box2">
        <VideoPlayer></VideoPlayer>
      </div>
    </div>
    <div class="timeline">
      Tiemline
    </div>
  </main>
</template>

<style>
@import './assets/base.css';

.grid-layout {
  display: grid;
  grid-template-columns: 50% 50%;
}

.box1, .box2 {
margin: 20px;
}

.timeline {
  display: grid;
  grid-template-columns: 100%;
}

#app {
  max-width: 100%;
  margin: 0 auto;
  padding: 0rem;
  font-weight: normal;
}
</style>
