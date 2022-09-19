<script setup>
import { RouterLink, RouterView } from "vue-router";

</script>

<template>
    
    <div class="content">
        <div class="kurse">
            <h1>Kursübersicht</h1>
            <div class="wrapper">
                <div class="box">
                    <div class="kurs_yoga" id="kurs">
                        <div class="kurs-header">
                            <img class="kurs-foto" src="src\assets\Images\dane-wetton-t1NEMSm1rgI-unsplash.jpg">
                        </div>
                        <div class="kurs-content">
                            <h2>Yoga für Anfänger</h2>
                            <p>In diesem Kurs werden einfache Grundstellungen für Einsteiger vorgeführt.</p>
                            <div class="icons">
                                <p><span class="material-symbols-outlined">groups</span>25
                                    Teilnehmer</p>
                                <p><span class="material-symbols-outlined">calendar_month</span>03.11.21 - 04.04.22</p><br>
                            </div>
                            <button class="btn-disabled" disabled>Zum Kurs</button>
                        </div>
                    </div>
                </div>
                <div class="box">
                    <div class="standard" id="kurs">
                        <div class="kurs-header">
                            <img class="kurs-foto" src="src\assets\Images\allef-vinicius-onGipw1rkPU-unsplash (1).jpg">
                        </div>
                        <div class="kurs-content">
                            <h2>Standardtanz</h2>
                            <p>Steigen Sie in
                                Standardtänze ein. Dieser Kurs setzt einen Tanzpartner voraus.</p>
                            <div class="icons">
                                <p><span class="material-symbols-outlined">groups</span>8
                                    Teilnehmer</p>
                                <p><span class="material-symbols-outlined">calendar_month</span>01.06.22 - 31.12.22</p><br>
                            </div>
                            <button class="btn-disabled" disabled>Zum Kurs</button>
                        </div>
                    </div>
                </div>
                <div class="box">

                    <div class="mocap" id="kurs">
                        <div class="kurs-header">
                            <img class="kurs-foto" src="src\assets\Images\ryan-garry-KeNddp0R9BE-unsplash.jpg">
                        </div>
                        <div class="kurs-content">
                            <h2>
                                Motion Capture
                            </h2>
                            <p>Hier finden Sie eine Auswahl an Motion Capture Bewegungen.</p>
                            <div class="icons">
                                <p><span class="material-symbols-outlined">groups</span>14 Teilnehmer</p>
                                <p><span class="material-symbols-outlined">calendar_month</span>01.07.22 - 31.10.22</p><br>
                            </div>
                            <RouterLink to="/videos"><button class="btn-enabled">Zum Kurs</button></RouterLink>
                        </div>
                    </div>
                </div>
                <div class="box">
                    <div class="kurs_yoga2" id="kurs">
                        <div class="kurs-header">
                            <img class="kurs-foto"
                                src="https://cdn.animaapp.com/projects/61aa0f6a37bc8119fc5ecf09/releases/61aa10dbfb6af9fb236efa16/img/unsplash-f2qh3yjz6jk@1x.png">
                        </div>
                        <div class="kurs-content">
                            <h2>Yoga für Fortgeschrittene</h2>
                            <p>In diesem Kurs werden komplizierte
                                Bewegungsabläufe vorgeführt.</p>
                            <div class="icons">
                                <p><span class="material-symbols-outlined">groups</span>9 Teilnehmer</p>
                                <p><span class="material-symbols-outlined">calendar_month</span>03. November - 04. April
                                </p><br>
                            </div>
                            <button class="btn-disabled" disabled>Zum Kurs</button>
                        </div>
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

.kurse{
    margin: 3rem;
}

h1 {
    margin-bottom: 3rem;
}


/*
.wrapper {
  display: grid;
  width: 2rem;
  grid-gap: 3rem;
  grid-template-columns: repeat(
    auto-fit,
    minmax(3, 1fr)
  );
  align-items: start;
}
@media(max-width: 800px) {
    .wrapper {
      grid-gap: 2rem;
    }
   }

.box1,
.box2,
.box3,
.box4 {
    padding: 2rem;
}
*/

.wrapper {
    max-width: 1000px;
    margin-left: 100px;
    margin-right: 100px;
    display: grid;
    gap: 1rem;
    place-self: center;
}


@media (max-width: 1100px) {
    .wrapper {
        grid-template-columns: repeat(2, 1fr);
        grid-template-areas: "kurs_yoga standard", "mocap kurs_yoga2";
        height: auto;
    }
}



.box {
    width: 400px;
    margin: 0 20px;
    display: grid;
    gap: 1rem;
}

#kurs {
    background-color: var(--surface-variant);
    color: var(--black);
    border-radius: 32px;
    overflow: hidden;
    height: 550px;
    width: 350px;
    max-width: 500px;
}

#kurs:hover {
    transition: all 0.2s ease-out;
    box-shadow: 0px 4px 8px rgba(0, 0, 0, .2);
    top: -5;
}

#kurs:before {
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

#kurs:hover:before {
    transform: scale(2.15);
}

h2, h1 {
    width: 100%;
    text-align:center;
}

.kurs-foto {
    height: 260px;
    width: 100% !important;
    object-fit: cover;
}

.kurs-content {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: flex-start;
    padding: 20px;
}

.kurs-content p {
    margin: 0 0 4px;
}

span {
    margin-right: 16px;
    color: var(--secondary);
}

.btn-disabled,
.btn-enabled {
    background-color: var(--primary);
    border: 0;
    border-radius: 50px;
    color: var(--white);
    font-size: 16px;
    padding: 12px 40px;
}

.btn-enabled :hover {
    background-color: var(--primary-70);
    color: var(--black);
    box-shadow: 0px 2px 4px var(--primary);
    border-color: var(--primary);
    border: 2px;
}

button:disabled,
button[disabled] {
    border: 1px solid #5B5F5E;
    background-color: #EFF1F0;
    color: #5B5F5E;
}
</style>