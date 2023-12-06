import flet as ft

def main(page):
    first_name = ft.TextField(value="Miles")
    last_name = ft.TextField(value="Kurts")
    first_name.disabled = False
    last_name.disabled = True
    page.add(first_name, last_name)

ft.app(target=main)