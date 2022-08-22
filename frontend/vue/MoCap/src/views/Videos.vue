<script setup>
import { RouterLink, RouterView } from "vue-router";

</script>

<template>
    <div class="videos">
        <button type="button" class="button-back"><RouterLink to="/">Zurück</RouterLink></button>
        <div class="kursname">Motion Capture</div>
        <div class="kurslaenge">In diesem Kurs finden Sie interaktive Videos, die Bewegungen über einen Avatar darstellen. Sie haben die Möglichkeit die einzelnen Videos zu pausieren und die Kamerasteuerung zu übernehmen.</div>
            <div class="wrapper">
                <div class="box1">
                    <div class="video_macarena" id="video">
                        <p class="video-laenge">20 Sekunden</p>
                        <div class="video-titel">
                            <RouterLink to="/player1">Macarena</RouterLink>
                        </div>
                        <img class="video-foto" src="src\assets\Images\dane-wetton-t1NEMSm1rgI-unsplash.jpg">
                    </div>
                </div>
                <div class="box2">
                    <div class="standard" id="video">
                        <p class="video-laenge">18 Sekunden</p>
                        <div class="video-titel">Ymca</div>
                        <img class="video-foto" src="src\assets\Images\allef-vinicius-onGipw1rkPU-unsplash (1).jpg">
                    </div>
                </div>
            
        </div>
    </div>

</template>

<script>
</script>

<style >
@import './../assets/base.css';

.videos {
    margin: 3rem;
}

.wrapper {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    grid-auto-rows: 550px;

}

.box1,
.box2,
.box3,
.box4 {
    padding: 2rem;
}

#video {
    background-color: var(--color-background-green);
    color: var(--white);
    border-radius: 32px;
    cursor: pointer;
    overflow: hidden;
    height: 329px;
    width: 446px;
}

.video-laenge {
    height: auto;
    left: 9px;
    line-height: normal;
    position: absolute;
    text-align: left;
    top: 300px;
}

.video-titel {
    left: 6px;
    top: 272px;
    font-size: 20px;
}

.video-titel a {
    text-decoration: none;
    color: var(--white);

}

.video-foto {
    height: 260px;
    left: -72px;
    object-fit: cover;
    position: absolute;
    top: 0px;
    width: 600px;
}

.kursname {
    font-size: 40px;
    text-align: center;
    color: var(--cyan);
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