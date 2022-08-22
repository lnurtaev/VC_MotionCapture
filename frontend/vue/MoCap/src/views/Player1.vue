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
        'src/assets/Unity/Build_Macarena/build-macarena.loader.js',
      dataUrl:
        'src/assets/Unity/Build_Macarena/build-macarena.data.gz',
      frameworkUrl:
        'src/assets/Unity/Build_Macarena/build-macarena.framework.js.gz',
      codeUrl:
        'src/assets/Unity/Build_Macarena/build-macarena.wasm.gz'
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
<button type="button" class="button-back"><RouterLink to="/videos">Zurück</RouterLink></button>
<div class="kursname">Macarena</div>
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
  width: 600px;
  height: 400px;
  border: 1px solid var(--kobe);
  border-radius: 20px;
  float: left;
  position: relative;
  left: 25%;
}

.button-back {
  border-radius: 20px;
  border: none;
  background-color: var(--kobe);
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
</style>