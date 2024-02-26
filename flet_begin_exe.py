import flet as ft
def main(page: ft.Page):
    btn = ft.ElevatedButton("Hi")
    page.add(btn)
ft.app(target=main)