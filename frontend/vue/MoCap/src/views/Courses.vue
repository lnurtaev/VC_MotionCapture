<script setup>
import { RouterLink, RouterView } from "vue-router";

</script>

<template>
    <div class="kurse">
        <div class="wrapper">
            <div class="box1">
                <div class="kurs_yoga" id="kurs">
                     
                    <p class="kurs-beschreibung">In diesem Kurs werden einfache Grundstellungen für Einsteiger vorgeführt.</p>
                    <p class="kurs-date-participants">25
                        Teilnehmer<br><br>03.11.21 - 04.04.22</p>
                    <div class="kurs-titel">Yoga für Anfänger</div>
                    <img class="kurs-foto" 
                        src="src\assets\Images\dane-wetton-t1NEMSm1rgI-unsplash.jpg">
                </div>
            </div>
            <div class="box2">
                <div class="standard" id="kurs">
                    <p class="kurs-beschreibung">Steigen Sie in
                        Standardtänze ein.</p>
                    <p class="kurs-date-participants">8
                        Teilnehmer<br><br>01.06.22 - 31.12.22</p>
                    <div class="kurs-titel">Standardtanz</div>
                    <img class="kurs-foto"
                        src="src\assets\Images\allef-vinicius-onGipw1rkPU-unsplash (1).jpg">
                </div>
            </div>
            <div class="box3">
                <div class="kurs_yoga" id="kurs">
                    <p class="kurs-beschreibung">Eine Auswahl an Motion Capture Bewegungen.</p>
                    <p class="kurs-date-participants">14
                        Teilnehmer<br><br>01.07.22 - 31.10.22</p>
                    <div class="kurs-titel"><RouterLink to="/videos">Motion Capture</RouterLink></div>
                    <img class="kurs-foto"
                        src="src\assets\Images\ryan-garry-KeNddp0R9BE-unsplash.jpg">
                </div>
            </div>
            <div class="box4">
                <div class="kurs_yoga2" id="kurs">
                    <p class="kurs-beschreibung">In diesem Kurs werden komplizierte
                        Bewegungsabläufe vorgeführt.</p>
                    <p class="kurs-date-participants">9
                        Teilnehmer<br><br>03. November - 04. April</p>
                    <div class="kurs-titel">Yoga für Fortgeschrittene</div>
                    <img class="kurs-foto"
                        src="https://cdn.animaapp.com/projects/61aa0f6a37bc8119fc5ecf09/releases/61aa10dbfb6af9fb236efa16/img/unsplash-f2qh3yjz6jk@1x.png">
                </div>
            </div>
        </div>
    </div>

</template>

<script>
</script>

<style >
@import './../assets/base.css';

.kurse {
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

#kurs{
    background-color: var(--color-background-green);
    color: var(--white);
    border-radius: 32px;
    cursor: pointer;
    overflow: hidden;
    height: 446px;
    width: 329px;
}

.kurs-beschreibung {
    height: auto;
    left: 9px;
    line-height: normal;
    position: absolute;
    text-align: left;
    top: 382px;
}

.kurs-date-participants {
    left: 35px;
    line-height: normal;
    position: absolute;
    top: 321px;
    width: 286px;
}

.kurs-titel {
    left: 6px;
    top: 272px;
    font-size: 20px;
}
.kurs-titel a {
    text-decoration: none;
    color: var(--white);
    
}

.kurs-foto {
    height: 260px;
    left: -72px;
    object-fit: cover;
    position: absolute;
    top: 0px;
    width: 500px;
}

.font-awesome-icon {
    color: aliceblue;
}
</style>