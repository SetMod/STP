from django.test import TestCase
from django.urls import reverse, resolve
from .views import HomePageView


class HomeTests(TestCase):
    def test_home_view_status_code(self):
        url = reverse('home')
        response = self.client.get(url)
        self.assertEquals(response.status_code, 200)

    def test_home_url_resolves_home_view(self):
        view = resolve('/')
        self.assertEquals(view.func.view_class, HomePageView)

    def test_articles_view_status_code(self):
        url = reverse('articles-list')
        response = self.client.get(url)
        self.assertEquals(response.status_code, 200)

    def test_category_view_status_code(self):
        url = reverse('articles-category-list', args={'slug': 'games'})
        response = self.client.get(url)
        self.assertEquals(response.status_code, 200)

    def test_news_detail_view_status_code(self):
        url = reverse(
            'news-detail', args={'year': '2022', 'month': '12', 'day': '03', 'slug': 'to-10-videos-by-views'})
        response = self.client.get(url)
        self.assertEquals(response.status_code, 200)
