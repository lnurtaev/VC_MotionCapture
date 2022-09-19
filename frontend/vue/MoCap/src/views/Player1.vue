<script setup>
import { ref, onMounted, onBeforeUnmount } from 'vue';
import UnityWebgl from 'unity-webgl';

const canvasRef = ref(null);
let unityComponent = null;

onMounted(() => {
  if (!unityComponent) {
    unityComponent = new UnityWebgl(canvasRef.value, {
      //Unity Projekt Dateien
      loaderUrl:
        'src/assets/Unity/Build_Macarena/v2/build-macarena.loader.js',
      dataUrl:
        'src/assets/Unity/Build_Macarena/v2/build-macarena.data.gz',
      frameworkUrl:
        'src/assets/Unity/Build_Macarena/v2/build-macarena.framework.js.gz',
      codeUrl:
        'src/assets/Unity/Build_Macarena/v2/build-macarena.wasm.gz'
    });
  }
});
onBeforeUnmount(() => {
  if (unityComponent) {
    unityComponent.destroy();
    unityComponent = null;
  }
});
</script>

<template>
<div class="content">
  <RouterLink to="/videos"><button type="button" class="button-back">Zur Videoübersicht</button></RouterLink>
<h1>Macarena</h1>
  <div class="window">
    <canvas id="canvas" ref="canvasRef" />
  </div>
  </div>
</template>

<style lang = "css" scoped>
.content {
  margin: 3rem;
}

#canvas {
  width: 100%;
  height: 100%;
  border-radius: 20px;
}

.window {
  margin: 30px;
  width: 800px;
  height: 550px;
  border: 1px solid var(--kobe);
  border-radius: 20px;
  position: relative;
  display: block;
  margin-left: auto;
  margin-right: auto;
}

@media (max-width: 1200px) {
    .window {
        width: 600px;
        height: 100%;
    }
}
@media (max-width: 800px) {
    .window {
        width: 400px;
        height: 100%;
    }
}
.button-back {
    border-radius: 50px;
    border: none;
    background-color: var(--secondary);
    color: white;
    padding: 15px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
}

.button-back a {
    text-decoration: none;
    color: white;
}

.button-back:hover {
    background-color: var(--secondary-70);
    box-shadow: 0px 2px 4px var(--secondary);
    border-color: var(--secondary);
    color: var(--black);
    border: 2px;
}
</style>