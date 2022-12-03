from django.http import HttpRequest, HttpResponse
from django.views.generic import TemplateView
from django.shortcuts import render
from typing import Any

# Create your views here.


class HomePageView(TemplateView):
    def get(self, request: HttpRequest, *args: Any, **kwargs: Any) -> HttpResponse:
        return render(request, 'index.html', context=None)
