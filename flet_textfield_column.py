import flet as ft

def main(page):
    first_name = ft.TextField(value="Miles")
    last_name = ft.TextField(value="Kurts")
    c = ft.Column(width=200, controls=[
        first_name,
        last_name
    ])
    c.disabled = False
    page.add(c)

ft.app(target=main)