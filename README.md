# MotionCapture
Das Projekt <b>Motion Capture for E Learning</b> wird semesterübergreifend an der TH Köln im Medieninformatik-Master (Schwerpunkt Visual Computing) bearbeitet. In drei Semestern werden die Phasen Konzept & Vision, Entwicklung und Forschung, Evaluation, Assessment, Verwertung aufeinander aufbauend ausgearbeitet.

### Teammitglieder:

* Lali Nurtaev
* Tristan Schmele
* Najla Barkallah


### Repository Erklärung:

* branch: feature/unity-player: Unity Dateien, in denen der Player mit den 3D Animationen vorhanden ist (übernommen)
* branch: NajlaBrk-patch-1 + NajlaBrk-patch-2: Frontend in HTML und CSS für die Ansichten (teils übernommen)
* branch: feature/unity-webgl-plugin: Frontend in Vue (übernommen)
* branch: setup: erste Version - Datenbank in couchdb (verworfen) + Frontendin Vue (übernommen für feature/unity-webgl-plugin)
* Ordner: MotionCapture_Aufnahmen: Aufnahmen aus dem Studio als bvh + bvh bereinigt + Avatar als fbx (nicht übernommen)
* branch: node_sql: sql Datenbank, auf die man mit node express Zugriff hat (verworfen, da Probleme mit BLOB Dateien und Pfadverweis für Unity Build Dateien)


### zum Starten:
* cd frontend/vue/MoCap
* npm install
* npm run dev
