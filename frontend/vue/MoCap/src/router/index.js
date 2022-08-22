import { createWebHistory, createRouter } from 'vue-router';
import Courses from '../views/Courses.vue';
import Profile from '../views/Profile.vue';
import Player1 from '../views/Player1.vue';
import Videos from '../views/Videos.vue';

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'courses',
      component: Courses
    }, {
        path: '/profil',
        name: 'profil',
        component: Profile
    }, {
      path: '/player1',
      name: 'player1',
      component: Player1
  }, {
    path: '/videos',
    name: 'videos',
    component: Videos
}
  ],
})

export default router;