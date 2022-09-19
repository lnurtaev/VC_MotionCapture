<script setup>
import { RouterLink, RouterView } from "vue-router";

</script>

<template>
    <div class="videos">
        <RouterLink to="/"><button type="button" class="button-back">Zur Kursübersicht</button></RouterLink>
        <h1>Motion Capture</h1>
        <div class="kurslaenge">In diesem Kurs finden Sie interaktive Videos, die Bewegungen über einen Avatar
            darstellen. Sie haben die Möglichkeit die einzelnen Videos zu pausieren und die Kamerasteuerung zu
            übernehmen.</div>
        <div class="wrapper">
            <div class="box1">
                <div class="video_macarena" id="video">
                    <div class="video-header"><img class="video-foto" src="\src\assets\Images\macarena.png"></div>
                    <div class="video-content">
                        <h2>Macarena</h2>
                        <p>In dem Video wird der Tanz Macarena vorgeführt.</p>
                        <div class="icons">
                            <p><span class="material-symbols-outlined">schedule</span>20 Sekunden</p>
                        </div>
                        <RouterLink to="/player1"><button class="btn-enabled">Zum Video</button></RouterLink>
                </div>
                </div>
            </div>
            <div class="box2">
                <div class="standard" id="video">
                    <div class="video-header"><img class="video-foto" src="\src\assets\Images\ymca.png"></div>
                    <div class="video-content">
                        <h2>
                            YMCA
                        </h2>
                        <p>In dem Video wird der Tanz YMCA vorgeführt.</p>
                        <div class="icons">
                            <p><span class="material-symbols-outlined">schedule</span>18 Sekunden</p>
                        </div>
                        <RouterLink to="/player2"><button class="btn-enabled">Zum Video</button></RouterLink>
                    </div>
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
    background-color: var(--surface-variant);
    color: var(--black);
    border-radius: 32px;
    overflow: hidden;
    height: 450px;
    width: 446px;
}

#video:hover {
    transition: all 0.2s ease-out;
    box-shadow: 0px 4px 8px rgba(0, 0, 0, .2);
    top: -5;
}

#video:before {
    content: "";
    position: absolute;
    z-index: -1;
    top: -16px;
    right: -16px;
    border-radius: 32px;
    transform: scale(2);
    transform-origin: 50% 50%;
    transition: transform 0.15s ease-out;
}

#video:hover:before {
    transform: scale(2.15);
}

.video-content {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: flex-start;
    padding: 20px;
}

.video-content p {
    margin: 0 0 4px;
}

span {
    margin-right: 16px;
    color: var(--secondary);
}

.btn-enabled:hover {
    background-color: var(--primary-70);
    box-shadow: 0px 2px 4px var(--primary);
    border-color: var(--primary);
    border: 2px;
}

.video-foto {
    height: 260px;
    width: 100% !important;
    object-fit: cover;
    width: 500px;
}



h2, h1 {
    width: 100%;
    text-align:center;
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