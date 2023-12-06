import flet as ft

def main(page: ft.Page):
    page.add(
        ft.TextField(label="Say your name"),
        ft.ElevatedButton(text="Say my name!")
    )
ft.app(target=main)