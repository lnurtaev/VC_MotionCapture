<script setup>
import { ref, onMounted, onBeforeUnmount } from 'vue';
import UnityWebgl from 'unity-webgl';

const canvasRef = ref(null);
let unityComponent = null;

onMounted(() => {
  if (!unityComponent) {
    unityComponent = new UnityWebgl(canvasRef.value, {
      //Placeholder Unity Projekt
      loaderUrl:
        'https://static-huariot-com.oss-cn-hangzhou.aliyuncs.com/unity/test1/Build/OUT_BIM.loader.js',
      dataUrl:
        'https://static-huariot-com.oss-cn-hangzhou.aliyuncs.com/unity/test1/Build/OUT_BIM.data',
      frameworkUrl:
        'https://static-huariot-com.oss-cn-hangzhou.aliyuncs.com/unity/test1/Build/OUT_BIM.framework.js',
      codeUrl:
        'https://static-huariot-com.oss-cn-hangzhou.aliyuncs.com/unity/test1/Build/OUT_BIM.wasm',
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
  <div class="window">
    <canvas id="canvas" ref="canvasRef" />
  </div>
</template>

<style lang = "css" scoped>
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
  float: center;
  border-radius: 20px;
}
</style>